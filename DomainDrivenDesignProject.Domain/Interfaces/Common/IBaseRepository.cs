namespace DomainDrivenDesignProject.Domain.Interfaces.Common;

public interface IBaseRepository<T, in TId>
  where T : class
  where TId : struct
{
  void Add(T data);
  IEnumerable<T> FindAll();
  T FindById(TId id);
  void Update(T data);
  void Remove(T data);
  void Dispose();
}
