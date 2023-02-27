namespace DomainDrivenDesignProject.Domain.Interfaces.Common;

public interface IBaseRepository<T, in TId>
  where T : class
  where TId : struct
{
  Task AddAsync(T data);
  Task<IEnumerable<T>> FindAllAsync();
  Task<T> FindByIdAsync(TId id);
  Task UpdateAsync(T data);
  Task RemoveAsync(TId id);

  void Dispose();
}
