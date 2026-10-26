namespace SAC.Domain.Entities;

public class HistoricoAtendimentoEntity
{
    public int Id { get; set; }
    public int AtendimentoId { get; set; }
    public int? ResponsavelId { get; set; }
    public int StatusId { get; set; }
    public DateTime DataHistorico { get; set; }
}