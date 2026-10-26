using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAC.Domain.Entities;

namespace SAC.Infrastructure.EntitiesConfiguration;

public class AtendimentoEntityConfiguration : IEntityTypeConfiguration<AtendimentoEntity>
{
    public void Configure(EntityTypeBuilder<AtendimentoEntity> builder)
    {
        builder.ToTable("Atendimento");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Descricao).IsRequired().HasMaxLength(500);
        builder.Property(p => p.Tipo).IsRequired().HasMaxLength(50);
        builder.Property(p => p.StatusId).IsRequired();
        builder.Property(p => p.ColaboradorId).IsRequired();
        builder.Property(p => p.DataAtendimento).IsRequired().HasDefaultValueSql("now()");

        builder.HasOne<ColaboradorEntity>()
        .WithMany()
        .HasForeignKey(p => p.ColaboradorId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ColaboradorEntity>()
        .WithMany().HasForeignKey(p => p.ResponsavelId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<StatusEntity>()
        .WithMany()
        .HasForeignKey(p => p.StatusId)
        .OnDelete(DeleteBehavior.Restrict);
    }
}