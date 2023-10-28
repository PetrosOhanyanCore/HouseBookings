using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IScoringRepository : IRepositoryBase<Scoring>
    {

        Task<IEnumerable<Scoring>> GetClientAllScoringsAsync(int clientId);
        Task<IEnumerable<Scoring>> GetClientAllScoringsByRateAsync(int clientId);
        Task<IEnumerable<Scoring>> GetClientAllScoringsByDateAsync(int clientId);
        Task<IEnumerable<Client>> GetAllClientsByHighestScoringRateAsync();
        Task<IEnumerable<Client>> GetAllClientsByLowestScoringRateAsync();

        Task<IEnumerable<Scoring>> GetAllApartmentsByScoreAsync();

        Task<IEnumerable<Scoring>> GetAllBuildingsByScoreAsync();

        Task<IEnumerable<Scoring>> GetClientScoringApartmentAsync(int clientId, int apartmentId);

        Task<IEnumerable<Scoring>> GetClientScoringBuildingAsync(int clientId, int buildingId);


    }
}
