using DatabaseContext;
using DatabaseModels;
using System.Runtime.ConstrainedExecution;

namespace Core;

public class Cert
{
    public static List<Certificate> List(int docId)
    {
        List<Certificate> certList = new();
        using (DbDoctors db = new())
        {
            var certs = db.Certificates.Where(c => c.DoctorId == docId).ToList<Certificate>();
            foreach (var cert in certs)
            {
                certList.Add(new Certificate()
                {
                    Id = cert.Id,
                    Description = cert.Description,
                    DoctorId = cert.DoctorId,
                    Date = cert.Date
                });
            }
        }
        return certList;
    }
   
    public static List<CertificateForTable> ListAll()
    {
        List<CertificateForTable> certList = new();
        using (DbDoctors db = new())
        {
            var certs =
                db.Certificates
                .Join(db.Doctors, c => c.DoctorId, d => d.Id,
                    (c, d) => new { Id = c.Id, Description = c.Description, Date = c.Date, Doctor = d.Name, Sid = d.SpecializationId })
                .Join(db.Specializations, d => d.Sid, s => s.Id,
                (d, s) => new { Id = d.Id, Description = d.Description, Date = d.Date, Doctor = d.Doctor, Specialization = s.Name });
            foreach (var c in certs)
            {
                certList.Add(
                    new CertificateForTable()
                    {
                        Id = c.Id,
                        Description = c.Description,
                        Doctor = c.Doctor,
                        Date = c.Date,
                        Specialization = c.Specialization
                    }
                );
            }
        }
        return certList;
    }
    public static void Add(int docId, string descr, DateTime date)
    {
        if (date > DateTime.Now)
            throw new Exception("дата не может быть позже сегодняшней");
        else
        {
            using (DbDoctors db = new())
            {
                Certificate? cer = db.Certificates.FirstOrDefault(c => c.Description == descr && c.DoctorId == docId);
                if (cer != null)
                {
                    throw new Exception("Такой сертификат у этого доктора уже есть в базе!");
                }

                Certificate newCert = new()
                {
                    DoctorId = docId,
                    Description = descr,
                    Date = DateOnly.FromDateTime(date),
                };

                db.Certificates.Add(newCert);
                db.SaveChanges();
            }
        }
    }

    public static void Edit(int certId, string descr, DateTime date)
    {
        if (date > DateTime.Now)
            throw new Exception("дата не может быть позже сегодняшней");
        else
        {
            using (DbDoctors db = new())
            {
                Certificate? cert = db.Certificates.FirstOrDefault(d => d.Id == certId);

                if (cert == null)
                {
                    throw new Exception("Не могу изменить серт, которого нет!");
                }

                cert.Description = descr;
                cert.Date = DateOnly.FromDateTime(date);
                db.SaveChanges();
            }
        }
    }

    public static void Del(int certId)
    { 
        using (DbDoctors db = new())
        {
            Certificate? cert = db.Certificates.FirstOrDefault(d => d.Id == certId);

            if (cert == null)
            {
                throw new Exception("Не могу удалить серт, которого нет!");
            }

            db.Certificates.Remove(cert);
            db.SaveChanges();
        }
    }

    public static DateOnly GetLatestCertDate(int docId)
    {
        var certs = List(docId);
        var res = DateOnly.FromDateTime(DateTime.Now);
        foreach (var cert in certs)
        {
            if (cert.Date.DayNumber < res.DayNumber)
                res = cert.Date;
        }
        return res;
    }

    public static string GetSpecializationToCert(int certId)
    {
        string res = "";
        using (DbDoctors db = new())
        {
            var cert = db.Certificates.FirstOrDefault(c => c.Id == certId);
            if (cert == null)
            {
                throw new Exception("Не могу найти серт, которого нет!");
            }
            var doc = db.Doctors.FirstOrDefault(d => d.Id == cert.DoctorId);
            var spec = db.Specializations.FirstOrDefault(s => s.Id == doc.SpecializationId);
            res = spec.ToString();
        }
        return res;
    }
}
