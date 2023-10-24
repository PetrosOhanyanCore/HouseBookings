using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Model;

namespace BusinessLayer.Service
{
    public class ScoringService : IScoringService
    {
        private readonly IScoringRepository _scoringRepository;
        private readonly IMapper _mapper;

        public ScoringService(IScoringRepository scoringRepository, IMapper mapper)
        {
            this._scoringRepository = scoringRepository;
            this._mapper = mapper;
        }

        public void AddScoring(ScoringDTO scoringDTO)
        {

            Scoring scoring = _mapper.Map<Scoring>(scoringDTO);
                _scoringRepository.Add(scoring);

        }



        public IEnumerable<ScoringDTO> FindScorings(Expression<Func<ScoringDTO, bool>> predicate)
        {

            Expression<Func<Entity.Scoring, bool>> entityPredicate
                = _mapper.Map<Expression<Func<Entity.Scoring, bool>>>(predicate);

            var scorings = _scoringRepository.Find(entityPredicate);

            return _mapper.Map<IEnumerable<ScoringDTO>>(scorings);

        }

        public ScoringDTO GetScoringById(int id)
        {
            var scoring = _scoringRepository.Get(id);
            return _mapper.Map<ScoringDTO>(scoring);
        }

        public IEnumerable<ScoringDTO> GetAllScorings()
        {
            var scorings = _scoringRepository.GetAll();
            return _mapper.Map<IEnumerable<ScoringDTO>>(scorings);
        }


        public async  Task<IEnumerable<ScoringDTO>> GetAllApartmentsByScoreAsync()
        {
            
            var result = await _scoringRepository.GetAllApartmentsByScoreAsync();
            return _mapper.Map<IEnumerable<ScoringDTO>>(result);

        }

        public async Task<IEnumerable<ScoringDTO>> GetAllBuildingsByScoreAsync()
        {
            var result = await _scoringRepository.GetAllBuildingsByScoreAsync();
            return _mapper.Map<IEnumerable<ScoringDTO>>(result);
        }

        public async Task<IEnumerable<ClientDTO>> GetAllClientsByHighestScoringRateAsync()
        {
            var result = await _scoringRepository.GetAllClientsByHighestScoringRateAsync();
            return _mapper.Map<IEnumerable<ClientDTO>>(result);
        }

        public async Task<IEnumerable<ClientDTO>> GetAllClientsByLowestScoringRateAsync()
        {
            var result = await _scoringRepository.GetAllClientsByLowestScoringRateAsync();
            return _mapper.Map<IEnumerable<ClientDTO>>(result);
        }

        public async Task<ScoringDTO> GetScoringAsync(int id)
        {
        
                var scoring = await _scoringRepository.GetAsync(id);
                return _mapper.Map<ScoringDTO>(scoring);
          
        }

        public async Task<IEnumerable<ScoringDTO>> GetClientAllScoringsAsync(int clientId)
        {
            var result = await _scoringRepository.GetClientAllScoringsAsync(clientId);
            return _mapper.Map<IEnumerable<ScoringDTO>>(result);
        }

        public async Task<IEnumerable<ScoringDTO>> GetClientAllScoringsByDateAsync(int clientId)
        {
            var result = await _scoringRepository.GetClientAllScoringsByDateAsync(clientId);
            return _mapper.Map<IEnumerable<ScoringDTO>>(result);
        }

        public async Task<IEnumerable<ScoringDTO>> GetClientAllScoringsByRateAsync(int clientId)
        {
            var result = await _scoringRepository.GetClientAllScoringsByRateAsync(clientId);
            return _mapper.Map<IEnumerable<ScoringDTO>>(result);
        }

        public async  Task<IEnumerable<ScoringDTO>> GetClientScoringApartmentAsync(int clientId, int apartmentId)
        {
            var result = await _scoringRepository.GetClientScoringApartmentAsync(clientId , apartmentId);
            return _mapper.Map<IEnumerable<ScoringDTO>>(result);
        }

        public async Task<IEnumerable<ScoringDTO>> GetClientScoringBuildingAsync(int clientId, int buildingId)
        {
            var result = await _scoringRepository.GetClientScoringApartmentAsync(clientId, buildingId);
            return _mapper.Map<IEnumerable<ScoringDTO>>(result);
        }

        public void RemoveScoring(ScoringDTO scoringDTO)
        {

            Scoring scoring = _mapper.Map<Scoring>(scoringDTO);
            _scoringRepository.Remove(scoring);
        }


        public void UpdateScoring(ScoringDTO scoringDTO)
        {
            Scoring scoring = _mapper.Map<Scoring>(scoringDTO);
            _scoringRepository.Update(scoring);
        }

    }
}
