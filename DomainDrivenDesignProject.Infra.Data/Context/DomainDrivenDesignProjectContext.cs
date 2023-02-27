using DomainDrivenDesignProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesignProject.Infra.Data.Context;

public class DomainDrivenDesignProjectContext : DbContext
{
  public DomainDrivenDesignProjectContext(DbContextOptions<DomainDrivenDesignProjectContext> options)
    : base(options)
  {
  }
  
  public DbSet<Client> Clients { get; set; }
  public DbSet<Product> Products { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(DomainDrivenDesignProjectContext).Assembly);
  }

  public override int SaveChanges()
  {
    var entries = ChangeTracker
      .Entries()
      .Where(e => e.Entity is Client && e.Entity.GetType().GetProperty("RegistrationDate") is not null);
    
    foreach (var entry in entries)
    {
      if (entry.State == EntityState.Added)
      {
        entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
      }

      if (entry.State == EntityState.Modified)
      {
        entry.Property("RegistrationDate").IsModified = false;
      }
    }
    
    return base.SaveChanges();
  }
}
