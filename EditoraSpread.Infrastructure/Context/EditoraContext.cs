using EditoraSpread.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EditoraSpread.Infrastructure.Context;

public class EditoraContext(DbContextOptions<EditoraContext> options) : DbContext(options)
{
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Livro> Livros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
