using DataLayer.IRepository;
using Entity;
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

        public IEnumerable<Scoring> GetClientAllScoring(int IdClinet)
        {
            List<Scoring> models = _context.Scorings
            .Where(p => p.ClientId == IdClinet)
            .ToList();

            return models;
        }
        public IEnumerable<Scoring> GetAllApartment()
        {
            List<Scoring> models = _context.Scorings
            .Where(p => p.IsApartment == true)
            .ToList();

            return models;
        }
        public IEnumerable<Scoring> GetAllBuilding()
        {
            List<Scoring> models = _context.Scorings
            .Where(p => p.IsBuilding == true)
            .ToList();

            return models;
        }
        public IEnumerable<Scoring> GetClientScoringApartment(int IdClinet, int IdApartment)
        {
            List<Scoring> models = _context.Scorings
            .Where(p => p.ClientId == IdClinet && p.ApartmentId == IdApartment)
            .ToList();

            return models;
        }
        public IEnumerable<Scoring> GetClientScoringBuilding(int IdClinet, int IdBuilding)
        {
            List<Scoring> models = _context.Scorings
            .Where(p => p.ClientId == IdClinet && p.BuildingId == IdBuilding)
            .ToList();

            return models;
        }
    }
}
