using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraSpread.Domain.Entities;

public class Livro
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Titulo { get; set; } = string.Empty;

    // Relação com Autor
    [Required]
    public int AutorId { get; set; }

    [ForeignKey("AutorId")]
    public Autor Autor { get; set; } = null!;

    // Relação com Gênero
    [Required]
    public int GeneroId { get; set; }

    [ForeignKey("GeneroId")]
    public Genero Genero { get; set; } = null!;
}
