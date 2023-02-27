using DomainDrivenDesignProject.Domain.Entities;
using DomainDrivenDesignProject.Domain.Interfaces;
using DomainDrivenDesignProject.Infra.Data.Context;
using DomainDrivenDesignProject.Infra.Data.Repositories.Common;

namespace DomainDrivenDesignProject.Infra.Data.Repositories;

public class ClientRepository : BaseRepository<Client, long>, IClientRepository
{
  public ClientRepository(DomainDrivenDesignProjectContext context) : base(context)
  {
  }
}
