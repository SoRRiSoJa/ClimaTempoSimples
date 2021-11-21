using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Abstractions.Repositories
{
    using ClimaTempoSimples.Models;
    public interface IPrevisaoClimaRepository
    {
        Task<List<PrevisaoClima>> GetThreeHottestCities();
        Task<List<PrevisaoClima>> GetThreeCoolertCities();
        Task<IEnumerable<PrevisaoClima>> GetWeekForecastByCityId(int idCidade);
    }
}