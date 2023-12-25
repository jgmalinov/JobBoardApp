using JobBoardApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JobBoardApp.Data;

public class JobBoardContext : DbContext
{
    public JobBoardContext(DbContextOptions<JobBoardContext> options) 
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Category>()
            .Property(e => e.Technologies)
            .HasConversion
            (
                v => v.ToString(),
                v => (Technologies) Enum.Parse(typeof(Technologies), v)
            );

    }

    public DbSet<Category> Categories;
    public DbSet<JobPosting> JobPostings;
    public DbSet<Company> Companies;
    public DbSet<Person> People;
}