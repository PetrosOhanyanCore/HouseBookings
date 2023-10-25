
using Model;
using System.Linq.Expressions;

namespace BusinessLayer.IService
{
    public interface IClientService
    {
        ClientDTO GetClient(int id);

        Task<ClientDTO> GetAsyncClient(int id);

        IEnumerable<ClientDTO> GetAllClient();
  
        IEnumerable<ClientDTO> FindClient(Expression<Func<ClientDTO, bool>> predicate);

        
        void AddClient(ClientDTO clientDTO);

        void RemoveClient(ClientDTO clientDTO);

        void UpdateClient(ClientDTO clientDTO);


    }
}
