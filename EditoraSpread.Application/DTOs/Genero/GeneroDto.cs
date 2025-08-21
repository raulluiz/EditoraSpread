using System.ComponentModel.DataAnnotations;

namespace EditoraSpread.Application.DTOs.Genero;

public class GeneroDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
}

public class CreateGeneroDto
{
    public string Nome { get; set; } = string.Empty;
}

public class UpdateGeneroDto
{
    [Required]
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
}