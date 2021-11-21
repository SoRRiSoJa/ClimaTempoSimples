using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Service
{
    using ClimaTempoSimples.Abstractions.Repositories;
    using ClimaTempoSimples.Abstractions.Services;
    using ClimaTempoSimples.Models;
    
    public class PrevisaoClimaService: IPrevisaoClimaService
    {
        private readonly IPrevisaoClimaRepository _previsaoClimaRepository;
        public PrevisaoClimaService(IPrevisaoClimaRepository _previsaoClimaRepository)
        {
            this._previsaoClimaRepository = _previsaoClimaRepository ?? throw new ArgumentNullException(nameof(_previsaoClimaRepository));
        }

        public async Task<IEnumerable<PrevisaoClima>> ObterPrevisaoSemanalParaUmaCidade(int idCidade)
        {
            return await _previsaoClimaRepository.GetWeekForecastByCityId(idCidade);
        }

        public async Task<List<PrevisaoClima>> ObterTresCidadesMaisFrias()
        {
            return await _previsaoClimaRepository.GetThreeCoolertCities();
        }

        public Task<List<PrevisaoClima>> ObterTresCidadesMaisQuentes()
        {
            return  _previsaoClimaRepository.GetThreeHottestCities();
        }
    }
}