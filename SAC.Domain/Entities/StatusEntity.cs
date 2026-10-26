namespace SAC.Domain.Entities;

public class StatusEntity
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }
    public bool Ativo { get; set; } = true;
}