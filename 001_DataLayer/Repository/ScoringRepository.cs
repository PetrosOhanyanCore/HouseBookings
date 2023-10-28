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
    public class ScoringRepository
      : RepositoryBase<Scoring>,
      IScoringRepository
    {
        public ScoringRepository(DataBaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Scoring>> GetClientAllScoringsAsync(int clientId)
        {
            var scorings = await _context.Scorings
                                    .Include(c => c.Client)
                                    .Where(s => s.ClientId == clientId)
                                    .ToListAsync();

            return scorings;
        }

        public async Task<IEnumerable<Scoring>> GetClientAllScoringsByRateAsync(int clientId)
        {
            var scorings = await _context.Scorings
                                        .Include(c => c.Client)
                                        .Where(s => s.ClientId == clientId)
                                        .GroupBy(s => s.Rate)
                                        .SelectMany(group => group)
                                        .ToListAsync();

            return scorings;
        }

        public async Task<IEnumerable<Scoring>> GetClientAllScoringsByDateAsync(int clientId)
        {
            var scorings = await _context.Scorings
                                        .Include(c => c.Client)
                                        .Where(s => s.ClientId == clientId)
                                        .GroupBy(s => s.Date)
                                        .SelectMany(group => group)
                                        .ToListAsync();

            return scorings;
        }


        public async Task<IEnumerable<Client>> GetAllClientsByHighestScoringRateAsync()
        {
            var clientsWithHighestRate = await _context.Clients
                .Include(c => c.Scorings)
                .Where(c => c.Scorings.Any())
                .OrderByDescending(c => c.Scorings.Max(s => s.Rate))
                .ToListAsync();

            return clientsWithHighestRate;
        }
        public async Task<IEnumerable<Client>> GetAllClientsByLowestScoringRateAsync()
        {
            var clientsWithLowestRate = await _context.Clients
               .Include(c => c.Scorings)
               .Where(c => c.Scorings.Any())
               .OrderByDescending(c => c.Scorings.Min(s => s.Rate))
               .ToListAsync();

            return clientsWithLowestRate;
        }



        public async Task<IEnumerable<Scoring>> GetAllApartmentsByScoreAsync()
        {
            List<Scoring> models = await _context.Scorings
            .Where(p => p.ApartmentId != null)
            .ToListAsync();

            return models;
        }
        public async Task<IEnumerable<Scoring>> GetAllBuildingsByScoreAsync()
        {
            List<Scoring> models = await _context.Scorings
            .Where(p => p.BuildingId != null)
            .ToListAsync();

            return models;
        }
        public async Task<IEnumerable<Scoring>> GetClientScoringApartmentAsync(int clientId, int apartmentId)
        {
            List<Scoring> models = await _context.Scorings
            .Where(p => p.ClientId == clientId && p.ApartmentId == apartmentId)
            .ToListAsync();

            return models;
        }
        public async Task<IEnumerable<Scoring>> GetClientScoringBuildingAsync(int clientId, int buildingId)
        {
            List<Scoring> models = await _context.Scorings
            .Where(p => p.ClientId == clientId && p.BuildingId == buildingId)
            .ToListAsync();

            return models;
        }
    }
}
