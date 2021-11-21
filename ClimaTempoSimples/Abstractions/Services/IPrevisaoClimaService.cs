using ClimaTempoSimples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ClimaTempoSimples.Abstractions.Services
{
    public interface IPrevisaoClimaService
    {
        Task<List<PrevisaoClima>> ObterTresCidadesMaisQuentes();
        Task<List<PrevisaoClima>> ObterTresCidadesMaisFrias();
        Task<IEnumerable<PrevisaoClima>> ObterPrevisaoSemanalParaUmaCidade(int idCidade);
    }
}