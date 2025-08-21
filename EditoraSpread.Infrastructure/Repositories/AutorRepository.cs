using EditoraSpread.Domain.Entities;
using EditoraSpread.Domain.Interfaces;
using EditoraSpread.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EditoraSpread.Infrastructure.Repositories;

public class AutorRepository : GenericRepository<Autor>, IAutorRepository
{
    private readonly EditoraContext _context;

    public AutorRepository(EditoraContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Autor>> BuscarPorNomeAsync(string nome)
    {
        return await _context.Autores
            .Where(a => a.Nome.Contains(nome))
            .ToListAsync();
    }
}
