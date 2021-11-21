using ClimaTempoSimples.Abstractions.Repositories;
using ClimaTempoSimples.Models;
using ClimaTempoSimples.Persistence.Config;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimaTempoSimples.Persistence.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {

        private ClimaTempoSimplesContext _db;
        public EstadoRepository()
        {
            this._db = new ClimaTempoSimplesContext();
        }
        public Estado Add(Estado item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Estado Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estado> GetAll()
        {
            return _db.Estados.ToList();
        }

        public bool Update(Estado item)
        {
            throw new NotImplementedException();
        }
    }
}