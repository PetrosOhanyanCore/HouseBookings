using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessLayer.IService
{
    public interface IScoringService
    {

        Task<IEnumerable<ScoringDTO>> GetClientAllScoringsAsync(int clientId);
        Task<IEnumerable<ScoringDTO>> GetClientAllScoringsByRateAsync(int clientId);
        Task<IEnumerable<ScoringDTO>> GetClientAllScoringsByDateAsync(int clientId);
        Task<IEnumerable<ClientDTO>> GetAllClientsByHighestScoringRateAsync();
        Task<IEnumerable<ClientDTO>> GetAllClientsByLowestScoringRateAsync();

        Task<IEnumerable<ScoringDTO>> GetAllApartmentsByScoreAsync();

        Task<IEnumerable<ScoringDTO>> GetAllBuildingsByScoreAsync();

        Task<IEnumerable<ScoringDTO>> GetClientScoringApartmentAsync(int clientId, int apartmentId);

        Task<IEnumerable<ScoringDTO>> GetClientScoringBuildingAsync(int clientId, int buildingId);

        ScoringDTO GetScoringById(int id);

        Task<ScoringDTO> GetScoringAsync(int id);
        IEnumerable<ScoringDTO> GetAllScorings();

        void AddScoring(ScoringDTO scoring);

        void RemoveScoring(ScoringDTO scoring);
        void UpdateScoring(ScoringDTO scoring);

    }
}
