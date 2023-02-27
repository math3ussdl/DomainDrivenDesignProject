namespace DomainDrivenDesignProject.Domain.Entities;

public class Product
{
  public long Id { get; set; }
  public string Name { get; set; }
  public decimal Value { get; set; }
  public bool Available { get; set; }
  public long ClientId { get; set; }
  public virtual Client Client { get; set; }
}
