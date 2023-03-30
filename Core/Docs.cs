using DatabaseContext;
using DatabaseModels;

namespace Core;

public class Docs
{
    public static List<Doctor> List()
    {
        List<Doctor> docs = new();
        using (DbDoctors db = new())
        {
            docs = db.Doctors.ToList<Doctor>();
        }
        return docs;
    }

    public static void Add(string name, int specId)
    {
        using (DbDoctors db = new())
        {
            Doctor? doc = db.Doctors.FirstOrDefault(d => d.Name == name);
            if (doc != null)
            {
                throw new Exception("Такой докстор уже есть в базе!");
            }

            Doctor newDoc = new() { Name = name, SpecializationId = specId };
            db.Doctors.Add(newDoc);
            db.SaveChanges();
        }
    }

    public static void Edit(int docId, string name, int specId)
    {
        using (DbDoctors db = new())
        {
            Doctor? doc = db.Doctors.FirstOrDefault(d => d.Id == docId);

            if (doc == null)
            {
                throw new Exception("Не могу изменить дока, которого нет!");
            }

            doc.Name = name;
            doc.SpecializationId = specId;
            db.SaveChanges();
        }
    }

    public static void Del(int docId)
    {
        using (DbDoctors db = new())
        {
            Doctor? doc = db.Doctors.FirstOrDefault(d => d.Id == docId);

            if (doc == null)
            {
                throw new Exception("Не могу удалить дока, которого нет!");
            }

            db.Doctors.Remove(doc);
            db.SaveChanges();
        }
    }
}