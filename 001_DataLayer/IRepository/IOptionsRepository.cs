using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IOptionsRepository : IRepositoryBase<Options>
    {

       public  Task<Options> GetOptionByIdAsync(int id);
        public Task<Apartment> GetApartmentByIdAsync(int id);
        public Task<Building> GetBuildingByIdAsync(int id);


    }




}
