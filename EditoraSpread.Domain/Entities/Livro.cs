namespace EditoraSpread.Domain.Entities;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;

    // FK Autor
    public int AutorId { get; set; }
    public Autor Autor { get; set; } = null!;

    // FK Gênero
    public int GeneroId { get; set; }
    public Genero Genero { get; set; } = null!;
}
