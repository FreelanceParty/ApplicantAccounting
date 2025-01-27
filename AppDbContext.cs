using ApplicantAccounting.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicantAccounting;

public class AppDbContext : DbContext
{
    public DbSet<Record> Records { get; set; }
    
    public AppDbContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnModelCreating(ModelBuilder  modelBuilder)
    {
        modelBuilder.Entity<Record>().HasKey(r => r.Id);
        base.OnModelCreating(modelBuilder);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=applicant_accounting.db");
    }
}