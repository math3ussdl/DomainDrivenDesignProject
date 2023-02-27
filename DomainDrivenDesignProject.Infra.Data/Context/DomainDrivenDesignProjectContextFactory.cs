using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DomainDrivenDesignProject.Infra.Data.Context;

public class DomainDrivenDesignProjectContextFactory : IDesignTimeDbContextFactory<DomainDrivenDesignProjectContext>
{
  public DomainDrivenDesignProjectContext CreateDbContext(string[] args)
  {
    var optsBuilder = new DbContextOptionsBuilder<DomainDrivenDesignProjectContext>();
    optsBuilder.UseSqlServer
      ("Server=localhost,1433;Database=DomainDriven;User ID=sa;Password=MsSQL2023;Encrypt=false");

    return new DomainDrivenDesignProjectContext(optsBuilder.Options);
  }
}
