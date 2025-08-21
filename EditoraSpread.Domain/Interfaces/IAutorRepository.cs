using EditoraSpread.Domain.Entities;

namespace EditoraSpread.Domain.Interfaces;

public interface IAutorRepository : IGenericRepository<Autor>
{
    // Exemplo de método específico
    Task<IEnumerable<Autor>> BuscarPorNomeAsync(string nome);
}
