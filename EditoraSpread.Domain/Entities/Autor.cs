namespace EditoraSpread.Domain.Entities;

public class Autor
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    // Relação 1:N
    public ICollection<Livro> Livros { get; set; } = [];
}
