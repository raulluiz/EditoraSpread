using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraSpread.Application.DTOs.Livro;

public class LivroDto
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public int AutorId { get; set; }
    public int GeneroId { get; set; }
}

public class CreateLivroDto
{
    public string Titulo { get; set; } = string.Empty;
    public int AutorId { get; set; }
    public int GeneroId { get; set; }
}

public class UpdateLivroDto
{
    [Required]
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public int AutorId { get; set; }
    public int GeneroId { get; set; }
}

