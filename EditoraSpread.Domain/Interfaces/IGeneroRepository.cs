using EditoraSpread.Domain.Entities;

namespace EditoraSpread.Domain.Interfaces;

public interface IGeneroRepository : IGenericRepository<Genero>
{
    Task<IEnumerable<Genero>> BuscarPorNomeAsync(string nome);

}
