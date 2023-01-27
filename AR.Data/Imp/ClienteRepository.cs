using AR.Data.Interfaces;
using AR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Data.Imp
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ContextoPricinpal _db;

        public ClienteRepository(ContextoPricinpal db) 
        { 
            _db = db; 
        }
        public async Task Add(Cliente entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _db.Cliente;
        }
    }
}
