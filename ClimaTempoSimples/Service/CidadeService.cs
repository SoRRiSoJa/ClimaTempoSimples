using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Service
{
    using ClimaTempoSimples.Abstractions.Repositories;
    using ClimaTempoSimples.Abstractions.Services;
    using ClimaTempoSimples.Models;

    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;
        public CidadeService(ICidadeRepository _cidadeRepository)
        {
            this._cidadeRepository = _cidadeRepository ?? throw new ArgumentNullException(nameof(_cidadeRepository));
        }
        public async Task<IEnumerable<Cidade>> ListarTodasAsync()
        {
            return await _cidadeRepository.GetAllAsync();
        }
    }
}