namespace DatabaseModels;

public class Certificate
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int DoctorId { get; set; }
    public DateOnly Date { get; set; }
    public override string ToString()
    {
        return Description + " - " + Date.ToString("dd MMMM yyyy");
    }
}

public class CertificateForTable
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Doctor { get; set; }
    public string Specialization { get; set; }
    public DateOnly Date { get; set; }
}
