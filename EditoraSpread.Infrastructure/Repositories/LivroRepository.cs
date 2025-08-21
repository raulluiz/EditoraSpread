using EditoraSpread.Domain.Entities;
using EditoraSpread.Domain.Interfaces;
using EditoraSpread.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EditoraSpread.Infrastructure.Repositories;

public class LivroRepository : GenericRepository<Livro>, ILivroRepository
{
    private readonly EditoraContext _context;

    public LivroRepository(EditoraContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Livro>> BuscarPorTituloAsync(string titulo)
    {
        return await _context.Livros
            .Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase))
            .ToListAsync();
    }

    public async Task<IEnumerable<Livro>> GetByAutorIdAsync(int autorId)
    {
        return await _context.Livros
            .Where(l => l.AutorId == autorId)
            .ToListAsync();
    }
}
