using DomainDrivenDesignProject.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DomainDrivenDesignProject.Infra.Data;

public static class InfraDataExtensions
{
  public static void ConfigureDataServices(this IServiceCollection services, IConfiguration configuration)
  {
    var connectionString = configuration.GetConnectionString("DbConnection");
    services.AddDbContext<DomainDrivenDesignProjectContext>(opts =>
    {
      opts.UseSqlServer(connectionString);
    });
  }
}
