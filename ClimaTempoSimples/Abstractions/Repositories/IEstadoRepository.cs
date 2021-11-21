using ClimaTempoSimples.Models;
using System.Collections.Generic;

namespace ClimaTempoSimples.Abstractions.Repositories
{
    public interface IEstadoRepository
    {
        IEnumerable<Estado> GetAll();
        Estado Get(int id);
        Estado Add(Estado item);
        bool Update(Estado item);
        bool Delete(int id);
    }
}
