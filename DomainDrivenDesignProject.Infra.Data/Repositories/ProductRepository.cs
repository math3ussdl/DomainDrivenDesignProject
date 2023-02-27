using DomainDrivenDesignProject.Domain.Entities;
using DomainDrivenDesignProject.Domain.Interfaces;
using DomainDrivenDesignProject.Infra.Data.Context;
using DomainDrivenDesignProject.Infra.Data.Repositories.Common;

namespace DomainDrivenDesignProject.Infra.Data.Repositories;

public class ProductRepository : BaseRepository<Product, long>, IProductRepository
{
  private readonly DomainDrivenDesignProjectContext _context;
  
  public ProductRepository(DomainDrivenDesignProjectContext context) : base(context)
  {
    _context = context;
  }

  public IEnumerable<Product> FindByNameContaining(string name)
  {
    return _context.Products.Where(p => p.Name.Contains(name));
  }
}
