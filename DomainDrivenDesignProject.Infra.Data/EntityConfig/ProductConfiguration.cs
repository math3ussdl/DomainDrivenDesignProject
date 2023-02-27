using DomainDrivenDesignProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainDrivenDesignProject.Infra.Data.EntityConfig;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
  public void Configure(EntityTypeBuilder<Product> builder)
  {
    builder.HasKey(p => p.Id);
    
    builder.Property(p => p.Name)
      .IsRequired()
      .HasMaxLength(250);

    builder.Property(p => p.Value)
      .IsRequired()
      .HasColumnType("decimal(10,2)");

    builder
      .HasOne(p => p.Client)
      .WithMany(c => c.Products)
      .HasForeignKey(p => p.ClientId)
      .IsRequired();
  }
}
