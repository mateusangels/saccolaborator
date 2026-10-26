namespace SAC.Domain.Entities;

public class AtendimentoEntity
{
    public int Id { get; set; }
    public required string Descricao { get; set; }

    public required string  Tipo { get; set; }

    public int StatusId { get; set; }

    public required int ColaboradorId { get; set; }

    public int? ResponsavelId { get; set; }

    public DateTime DataAtendimento { get; set; }
}