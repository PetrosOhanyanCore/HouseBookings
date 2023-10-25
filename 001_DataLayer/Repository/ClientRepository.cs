using DataLayer.IRepository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(DataBaseContext context) : base(context)
        {
            
        }
        /*
        public IEnumerable<Client> GetAllClients()
        {
            var clients = _context.Clients.ToList();
            return clients;
        }

        public Client GetCLientByID(int id)
        {
           var client= _context.Clients.FirstOrDefault(c => c.Id == id);
           return client;
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(c => c.Id == id);
            return client;
        }
        */
    }
}
