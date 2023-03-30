namespace DatabaseModels;

public class Specialization
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
