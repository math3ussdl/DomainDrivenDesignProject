using DomainDrivenDesignProject.Domain.Interfaces.Common;
using DomainDrivenDesignProject.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesignProject.Infra.Data.Repositories.Common;

public class BaseRepository<T, TId> : IDisposable, IBaseRepository<T, TId>
  where T : class
  where TId: struct
{
  private readonly DomainDrivenDesignProjectContext _context;
  
  public BaseRepository(DomainDrivenDesignProjectContext context)
  {
    _context = context;
  }
  
  public void Add(T data)
  {
    _context.Set<T>().Add(data);
    _context.SaveChanges();
  }

  public IEnumerable<T> FindAll()
  {
    return _context.Set<T>().ToList();
  }

  public T FindById(TId id)
  {
    return _context
      .Set<T>()
      .Find(id)
        ?? throw new KeyNotFoundException("Registry not found!");
  }

  public void Update(T data)
  {
    _context.Entry(data).State = EntityState.Modified;
    _context.SaveChanges();
  }

  public void Remove(T data)
  {
    _context.Set<T>().Remove(data);
    _context.SaveChanges();
  }

  public void Dispose()
  {
    GC.SuppressFinalize(this);
  }
}
