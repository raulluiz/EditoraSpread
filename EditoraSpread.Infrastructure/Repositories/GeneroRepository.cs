using EditoraSpread.Domain.Entities;
using EditoraSpread.Domain.Interfaces;
using EditoraSpread.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace EditoraSpread.Infrastructure.Repositories;

public class GeneroRepository : GenericRepository<Genero>, IGeneroRepository
{
    private readonly EditoraContext _context;

    public GeneroRepository(EditoraContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Genero>> BuscarPorNomeAsync(string nome)
    {
        return await _context.Generos
            .Where(g => EF.Functions.Like(g.Nome, $"%{nome}%"))
            .ToListAsync();
    }
}
