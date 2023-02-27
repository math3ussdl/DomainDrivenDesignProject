using DomainDrivenDesignProject.Domain.Entities;
using DomainDrivenDesignProject.Domain.Interfaces.Common;

namespace DomainDrivenDesignProject.Domain.Interfaces;

public interface IProductRepository : IBaseRepository<Product, long>
{
  IEnumerable<Product> FindByNameContaining(string name);
}
