using ClimaTempoSimples.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Abstractions.Repositories
{
    public interface ICidadeRepository
    {
        Task<IEnumerable<Cidade>> GetAllAsync();
        Task<Cidade> Get(int id);
    }
}
