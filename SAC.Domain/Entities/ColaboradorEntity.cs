namespace SAC.Domain.Entities;

public class ColaboradorEntity
{
    public int Id { get; set; }
    public required string Nome { get; set; }

    public required string Email { get; set; }
    public string? Cargo { get; set; }

    public string? Telefone { get; set; }

    public DateTime? Admissao { get; set; }

    public bool Ativo { get; set; } = true;
}