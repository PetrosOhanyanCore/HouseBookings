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

        IEnumerable<Scoring> GetClientAllScoring(int IdClinet);

        IEnumerable<Scoring> GetAllApartment();

        IEnumerable<Scoring> GetAllBuilding();

        IEnumerable<Scoring> GetClientScoringApartment(int IdClinet, int IdApartment);

        IEnumerable<Scoring> GetClientScoringBuilding(int IdClinet, int IdBuilding);


    }
}
