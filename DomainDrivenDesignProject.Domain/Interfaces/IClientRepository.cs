using DomainDrivenDesignProject.Domain.Entities;
using DomainDrivenDesignProject.Domain.Interfaces.Common;

namespace DomainDrivenDesignProject.Domain.Interfaces;

public interface IClientRepository : IBaseRepository<Client, long>
{
}
