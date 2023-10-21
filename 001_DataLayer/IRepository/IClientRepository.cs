 using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        Client GetCLientByID(int id);
        Task<Client> GetClientByIdAsync(int id);
        IEnumerable<Client> GetAllClients();

    }
}
