using Model.DTO;

namespace BusinessLayer.IService
{
    public interface IClientService
    {
        Task<ClientDTO> GetClientAsync(int id);

        Task<IEnumerable<ClientDTO>> GetAllClientAsync();
         
        Task AddClientAsync(ClientDTO clientDTO);

        Task RemoveClientAsync(ClientDTO clientDTO);

        Task UpdateClientAsync(ClientDTO clientDTO);


    }
}
