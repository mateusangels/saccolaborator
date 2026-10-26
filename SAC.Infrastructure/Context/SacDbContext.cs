using Microsoft.EntityFrameworkCore;
using SAC.Domain.Entities;

namespace SAC.Infrastructure.Context;

public class SacDbContext : DbContext
{
    public SacDbContext(DbContextOptions<SacDbContext> options) : base(options) { }
    public DbSet<ColaboradorEntity> Colaboradores { get; set; }
    public DbSet<AtendimentoEntity> Atendimentos { get; set; }
    public DbSet<HistoricoAtendimentoEntity> Historico { get; set; }
    public DbSet<StatusEntity> Status { get; set; }

}