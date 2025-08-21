using System.ComponentModel.DataAnnotations;

namespace EditoraSpread.Application.DTOs.Autor;

public class AutorDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
}

public class AutorUpdateDto
{
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do autor é obrigatório")]
    [StringLength(100)]
    public string Nome { get; set; } = string.Empty;
}

public class AutorCreateDto
{
    [Required(ErrorMessage = "O nome do autor é obrigatório")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
    public string Nome { get; set; } = string.Empty;
}