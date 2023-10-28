
using DataLayer.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IApartmentImageRepository : IRepositoryBase<ApartmentImage>
    {
        ApartmentImage GetImageByID(int id);
        Task<ApartmentImage> GetImageByIdAsync(int id);

        IEnumerable<ApartmentImage> GetAllImages(int buildingId);
    }
}