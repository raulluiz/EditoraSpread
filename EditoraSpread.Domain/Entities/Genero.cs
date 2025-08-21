using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraSpread.Domain.Entities;

public class Genero
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;

    // Propriedade de navegação para a coleção de Livros
    [InverseProperty("Genero")]
    public ICollection<Livro> Livros { get; set; } = [];
}