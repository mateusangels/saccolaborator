using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAC.Domain.Entities;

namespace SAC.Infrastructure.EntitiesConfiguration;

public class HistoricoAtendimentoEntityConfiguration : IEntityTypeConfiguration<HistoricoAtendimentoEntity>
{
    public void Configure(EntityTypeBuilder<HistoricoAtendimentoEntity> builder)
    {
        builder.ToTable("HistoricoAtendimento");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.AtendimentoId);
        builder.Property(p => p.DataHistorico).IsRequired().HasDefaultValueSql("now()");
        builder.Property(p => p.StatusId);

        builder.HasOne<AtendimentoEntity>()
       .WithMany()
       .HasForeignKey(p => p.AtendimentoId)
       .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ColaboradorEntity>()
        .WithMany()
        .HasForeignKey(p => p.ResponsavelId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<StatusEntity>()
        .WithMany()
        .HasForeignKey(p => p.StatusId)
        .OnDelete(DeleteBehavior.Restrict);
    }
}