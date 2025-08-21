using EditoraSpread.Domain.Entities;
using EditoraSpread.Domain.Interfaces;

namespace EditoraSpread.Application.Services;

public class LivroService
{
    private readonly ILivroRepository _livroRepository;

    public LivroService(ILivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    public async Task<IEnumerable<Livro>> ObterTodosAsync()
        => await _livroRepository.GetAllAsync();

    public async Task<Livro?> ObterPorIdAsync(int id)
        => await _livroRepository.GetByIdAsync(id);

    public async Task CriarAsync(Livro livro)
        => await _livroRepository.AddAsync(livro);

    public async Task AtualizarAsync(Livro livro)
        => await _livroRepository.UpdateAsync(livro);

    public async Task RemoverAsync(int id)
        => await _livroRepository.DeleteAsync(id);

    public async Task<IEnumerable<Livro>> BuscarPorTituloAsync(string titulo)
        => await _livroRepository.BuscarPorTituloAsync(titulo);
}