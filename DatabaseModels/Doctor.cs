namespace DatabaseModels;

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int SpecializationId { get; set; }
    public override string ToString()
    {
        return Name;
    }
}