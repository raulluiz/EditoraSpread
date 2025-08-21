using EditoraSpread.Domain.Entities;
using EditoraSpread.Domain.Interfaces;

namespace EditoraSpread.Application.Services;

public class GeneroService
{
    private readonly IGeneroRepository _generoRepository;

    public GeneroService(IGeneroRepository generoRepository)
    {
        _generoRepository = generoRepository;
    }

    public async Task<IEnumerable<Genero>> ObterTodosAsync()
        => await _generoRepository.GetAllAsync();

    public async Task<Genero?> ObterPorIdAsync(int id)
        => await _generoRepository.GetByIdAsync(id);

    public async Task CriarAsync(Genero genero)
        => await _generoRepository.AddAsync(genero);

    public async Task AtualizarAsync(Genero genero)
        => await _generoRepository.UpdateAsync(genero);

    public async Task RemoverAsync(int id)
        => await _generoRepository.DeleteAsync(id);

    public async Task<IEnumerable<Genero>> BuscarPorNomeAsync(string nome)
        => await _generoRepository.BuscarPorNomeAsync(nome);
}
