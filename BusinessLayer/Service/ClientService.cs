
using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Model;
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

        public void AddClient(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            _clientRepository.Add(client);
        }
        public IEnumerable<ClientDTO> FindClient(Expression<Func<ClientDTO, bool>> predicate)
        {
            Expression<Func<Entity.Client, bool>> entityPredicate = _mapper.Map<Expression<Func<Entity.Client, bool>>>(predicate);

            var clients = _clientRepository.Find(entityPredicate);
            return _mapper.Map<IEnumerable<ClientDTO>>(clients);
        }


        
        public IEnumerable<ClientDTO> GetAllClient()
        {
           var clients = _clientRepository.GetAll();
            return _mapper.Map<IEnumerable<ClientDTO>>(clients);
        }

        public async Task<ClientDTO> GetAsyncClient(int id)
        {
            var client = await _clientRepository.GetAsync(id);
            return _mapper.Map<ClientDTO>(client);
        }

        public ClientDTO GetClient(int id)
        {
            var client = _clientRepository.Get(id);
            return _mapper.Map<ClientDTO>(client);
        }

        public void RemoveClient(ClientDTO clientDTO)
        {
            var  client = _mapper.Map<Client>(clientDTO);
            var existingClient = _clientRepository.Get(client.Id);

            if (existingClient != null)
            {
                _clientRepository.Remove(client);
            }
            else
            {
                ArgumentException argumentException = new("Client does not exist.", nameof(clientDTO));
                throw argumentException;
            }

        }

        public void UpdateClient(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            var existingClient = _clientRepository.Get(client.Id);
            if (existingClient != null)
            {
                _clientRepository.Update(client);
            }
            else
            {
                ArgumentException argumentException = new ArgumentException("Client does not exist.", nameof(clientDTO));
                throw argumentException;
            }
        }

    }
}
