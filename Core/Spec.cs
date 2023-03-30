using DatabaseContext;
using DatabaseModels;

namespace Core;

public class Spec
{
    public static List<Specialization> List()
    {
        List<Specialization> spes = new();
        using (DbDoctors db = new())
        {
            spes = db.Specializations.ToList<Specialization>();
        }
        return spes;
    }

    public static void Add(string name)
    {
        if (name == "")
            throw new Exception("ошибка имени");

        using (DbDoctors db = new())
        {
            Specialization? spec = db.Specializations.FirstOrDefault(s => s.Name == name);
            if(spec != null)
            {
                throw new Exception("Специя с таким именем уже есть в базе!");
            }

            Specialization newSpec = new() { Name = name };
            db.Specializations.Add(newSpec);
            db.SaveChanges();
        }
    }

    public static void Edit(int specId, string name)
    {
        using (DbDoctors db = new())
        {
            Specialization? spec = db.Specializations.FirstOrDefault(s => s.Id == specId);
            if (spec == null)
            {
                throw new Exception("Не могу изменить спецу, которой нет!");
            }

            spec.Name = name;
            db.SaveChanges();
        }
    }

    public static void Del(int specId)
    {
        using (DbDoctors db = new())
        {
            Specialization? spec = db.Specializations.FirstOrDefault(s => s.Id == specId);
            if (spec == null)
            {
                throw new Exception("Не могу удалить спецу, которой нет!");
            }

            db.Specializations.Remove(spec);
            db.SaveChanges();
        }
    }

    public static int GetDocCount(int specId)
    {
        int cnt = 0;
        using (DbDoctors db = new())
        {
            cnt = db.Doctors.Where(d => d.SpecializationId == specId).Count();
        }

        return cnt;
    }

}
