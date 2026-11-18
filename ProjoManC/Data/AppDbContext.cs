using Microsoft.EntityFrameworkCore;
using ProjoManC.Models;

namespace ProjoManC.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Project> Projects => Set<Project>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasIndex(b => b.Email)
            .IsUnique()
            .HasFilter("Email IS NOT NULL AND Email <> ''");
    }
}