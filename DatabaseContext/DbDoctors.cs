using Microsoft.EntityFrameworkCore;
using DatabaseModels;

namespace DatabaseContext;

public class DbDoctors : DbContext
{
    public DbDoctors()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql("Host=localhost;Port=5433;Database=DoctorsDb1;Username=postgres;pwd=1234"); ;
    }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Specialization> Specializations { get; set; }
}