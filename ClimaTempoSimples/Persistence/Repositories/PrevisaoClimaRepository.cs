using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Persistence.Repositories
{
    using ClimaTempoSimples.Abstractions.Repositories;
    using ClimaTempoSimples.Models;
    using ClimaTempoSimples.Persistence.Config;

    public class PrevisaoClimaRepository : IPrevisaoClimaRepository
    {
        private ClimaTempoSimplesContext _db;
        public PrevisaoClimaRepository()
        {
            this._db = new ClimaTempoSimplesContext();
        }
        
        public async Task<List<PrevisaoClima>> GetThreeHottestCities()
        {
            var list = await _db.PrevisoesClima.Where(pc=>pc.DataPrevisao.CompareTo(DateTime.Today)==0).GroupBy(pc => pc.CidadeId).
                Select(x => x.FirstOrDefault()).
                OrderByDescending(x => x.TemperaturaMaxima).
                Take(3).
                ToListAsync();
            return list;


            


        }
        public async Task<List<PrevisaoClima>> GetThreeCoolertCities()
        {
            var list = await _db.PrevisoesClima.Where(pc => pc.DataPrevisao.CompareTo(DateTime.Today) == 0).GroupBy(pc => pc.CidadeId).
                 Select(x => x.FirstOrDefault()).
                 OrderBy(x => x.TemperaturaMinima).
                 Take(3).
                 ToListAsync();
            return list;

        }
        public async Task<IEnumerable<PrevisaoClima>> GetWeekForecastByCityId(int idCidade)
        {
            try
            {
                var result = await _db.PrevisoesClima
               .Include((pc) => (pc).Cidade)
               .Where((pc) => (pc).CidadeId == idCidade && pc.DataPrevisao.CompareTo(DateTime.Today)>=0)
               .OrderBy((pc) => pc.DataPrevisao)
               .Take(7)
               .ToListAsync();
                return result;
            }
            catch (Exception )
            {
                throw ;
            }
            
        }

    }
}