using EditoraSpread.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraSpread.Domain.Interfaces
{
    public interface ILivroRepository : IGenericRepository<Livro>
    {
        Task<IEnumerable<Livro>> BuscarPorTituloAsync(string titulo);
        Task<IEnumerable<Livro>> GetByAutorIdAsync(int autorId);
    }
}
