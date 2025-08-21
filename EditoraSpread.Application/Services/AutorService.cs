using EditoraSpread.Domain.Entities;
using EditoraSpread.Domain.Interfaces;

namespace EditoraSpread.Application.Services;

public class AutorService
{
    private readonly IAutorRepository _autorRepository;

    public AutorService(IAutorRepository autorRepository)
    {
        _autorRepository = autorRepository;
    }

    public async Task<IEnumerable<Autor>> ObterTodosAsync()
        => await _autorRepository.GetAllAsync();

    public async Task<Autor?> ObterPorIdAsync(int id)
        => await _autorRepository.GetByIdAsync(id);

    public async Task CriarAsync(Autor autor)
        => await _autorRepository.AddAsync(autor);

    public async Task AtualizarAsync(Autor autor)
        => await _autorRepository.UpdateAsync(autor);

    public async Task RemoverAsync(int id)
        => await _autorRepository.DeleteAsync(id);

    public async Task<IEnumerable<Autor>> BuscarPorNomeAsync(string nome)
        => await _autorRepository.BuscarPorNomeAsync(nome);
}
