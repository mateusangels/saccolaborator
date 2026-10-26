using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAC.Domain.Entities;

namespace SAC.Infrastructure.EntitiesConfiguration;

public class ColaboradorEntityConfiguration : IEntityTypeConfiguration<ColaboradorEntity>
{
    public void Configure(EntityTypeBuilder<ColaboradorEntity> builder)
    {
        builder.ToTable("Colaboradores");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Email).IsRequired().HasMaxLength(100);
        builder.HasIndex(p => p.Email).IsUnique();
        builder.Property(p => p.Cargo).HasMaxLength(100);
        builder.Property(p => p.Telefone).HasMaxLength(100);
        builder.Property(p => p.Admissao).HasColumnType("date");
        builder.Property(p => p.Ativo).HasDefaultValue(true);
    }
}