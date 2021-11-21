using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Abstractions.Services
{
    using ClimaTempoSimples.Models;
    public interface ICidadeService
    {
        Task<IEnumerable<Cidade>> ListarTodasAsync();
    }
}
