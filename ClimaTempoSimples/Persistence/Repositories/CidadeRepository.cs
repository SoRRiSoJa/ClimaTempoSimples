using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaTempoSimples.Persistence.Repositories
{
    using ClimaTempoSimples.Abstractions.Repositories;
    using ClimaTempoSimples.Models;
    using ClimaTempoSimples.Persistence.Config;
    public class CidadeRepository : ICidadeRepository
    {
        private ClimaTempoSimplesContext _db;
        public CidadeRepository()
        {

            this._db = new ClimaTempoSimplesContext();
        }

        public async Task<Cidade> Get(int id)
        {
            return await _db.Cidades.Include((cid) => cid.Estado).Where((cid) => (cid).Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cidade>> GetAllAsync()
        {
            return await _db.Cidades.Include((cid) => cid.Estado).ToListAsync();
        }

    }
}