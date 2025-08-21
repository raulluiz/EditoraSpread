namespace EditoraSpread.Domain.Entities;

public class Genero
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    // Relação 1:N
    public ICollection<Livro> Livros { get; set; } = [];
}