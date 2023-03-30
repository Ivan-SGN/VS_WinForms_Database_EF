using DatabaseContext;
using DatabaseModels;

namespace Core;

public class AppLogic
{ 

    public static string CheckDb()
    {
        using (DbDoctors db = new())
        {
            var docs = db.Doctors;
            try
            {
                foreach (var doc in docs)
                {
                    var n = doc.Name;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        return "Db OK!";
    }

    public static int GetDocCount(int specId) => Spec.GetDocCount(specId);
    public static DateOnly GetLatestCertDate(int docId) => Cert.GetLatestCertDate(docId);
    public static string GetSpecializationToCert(int certId) => Cert.GetSpecializationToCert(certId);

    public static List<CertificateForTable> GetAllCertificates() => Cert.ListAll();
    public static List<Certificate> GetDocCertificates(int doctorId) => Cert.List(doctorId);
    public static void AddSertificate(int docId, string descr, DateTime date) => Cert.Add(docId, descr, date);
    public static void EditCertificate(int certId, string descr, DateTime date) => Cert.Edit(certId, descr, date);
    public static void DelCertificate(int certId) => Cert.Del(certId);

    public static List<Specialization> GetSpecializations() => Spec.List();
    public static void AddSpecialization(string name) => Spec.Add(name);
    public static void EditSpecialization(int specId, string name) => Spec.Edit(specId, name);
    public static void DelSpecialization(int specId) => Cert.Del(specId);

    public static List<Doctor> GetDoctors() => Docs.List();
    public static void AddDoctor(string name, int specId) => Docs.Add(name, specId);
    public static void EditDoctor(int docId, string name, int specId) => Docs.Edit(docId, name, specId);
    public static void DelDoctor(int docId) => Docs.Del(docId);


}


