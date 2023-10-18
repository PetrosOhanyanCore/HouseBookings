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

        public IEnumerable<Scoring> GetAllBuilding()
        {
            List<Scoring> models = _context.Scorings
            .Where(p => p.IsBuilding == true)
            .ToList();

            return models;
        }
    }
}
