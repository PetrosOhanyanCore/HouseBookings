
using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Model.DTO;
using Model.Mapper;
using System.Linq.Expressions;

namespace BusinessLayer.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;
        public ClientService(IClientRepository clientRepository, IMapper maper)
        {
            this._clientRepository = clientRepository;
            this._mapper = maper;

        }

        public async Task AddClientAsync(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            await _clientRepository.AddAsync(client);
        }

        public async Task<IEnumerable<ClientDTO>> GetAllClientAsync()
        {
            var clients = await _clientRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ClientDTO>>(clients);
        }

        

        public async Task<ClientDTO> GetClientAsync(int id)
        {
            var client = await _clientRepository.GetAsync(id);
            return _mapper.Map<ClientDTO>(client); 
        }

        public async Task RemoveClientAsync(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            var existingClient = await _clientRepository.GetAsync(client.Id);

            if (existingClient != null)
            {
                //_clientRepository.Remove(client);
                await _clientRepository.RemoveAsync(existingClient);
            }
            else
            {
                ArgumentException argumentException = new("Client does not exist.", nameof(clientDTO));
                throw argumentException;
            }

        }

        public async Task UpdateClientAsync(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            
            var existingClient = await _clientRepository.GetAsync(client.Id);

            if (existingClient != null)
            {
                //    _clientRepository.Update(client);
                await _clientRepository.UpdateAsync(existingClient);
            }
            else
            {
                ArgumentException argumentException = new("Client does not exist.", nameof(clientDTO));
                throw argumentException;
            }

        }
    }
}

            


   