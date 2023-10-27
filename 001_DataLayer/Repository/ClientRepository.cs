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

        public async Task AddAsync(Client client)
        {
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Client client)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task UpdateAsync(Client client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
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
