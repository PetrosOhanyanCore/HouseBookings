
using DataLayer.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IImageRepository : IRepositoryBase<Image>
    {
        Image GetImageByID(int id);
        Task<Image> GetImageByIdAsync(int id);

        IEnumerable<Image> GetAllImages(int buildingId);
    }
}