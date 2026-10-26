using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAC.Domain.Entities;

namespace SAC.Infrastructure.EntitiesConfiguration;

public class StatusEntityConfiguration : IEntityTypeConfiguration<StatusEntity>
{
    public void Configure(EntityTypeBuilder<StatusEntity> builder)
    {
        builder.ToTable("Status");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Nome).IsRequired().HasMaxLength(255);
        builder.HasIndex(p => p.Nome).IsUnique();
        builder.Property(p => p.Descricao).HasMaxLength(500);
        builder.Property(p => p.Ativo).HasDefaultValue(true);
    }
}