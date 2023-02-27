using DomainDrivenDesignProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainDrivenDesignProject.Infra.Data.EntityConfig;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
  public void Configure(EntityTypeBuilder<Client> builder)
  {
    builder.HasKey(c => c.Id);
    
    builder.Property(c => c.Name)
      .IsRequired()
      .HasMaxLength(150);

    builder.Property(c => c.Surname)
      .IsRequired()
      .HasMaxLength(150);

    builder.Property(c => c.Email)
      .IsRequired();
  }
}
