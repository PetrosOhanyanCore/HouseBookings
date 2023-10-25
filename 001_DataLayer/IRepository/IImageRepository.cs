
using DataLayer.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IImageRepository : IRepositoryBase<Image<Type>>
    {
        Image<Type> GetImageByID(int id);
        Task<Image<Type>> GetImageByIdAsync(int id);

        IEnumerable<Image<Type>> GetAllImages(int buildingId);
    }
}