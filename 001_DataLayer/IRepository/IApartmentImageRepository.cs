
using DataLayer.IRepository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IApartmentImageRepository : IRepositoryBase<ApartmentImage>
    { 

        Task<ICollection<ApartmentImage>> GetApartmentAllImagesAsync(int apartmentId);
        void RemoveApartmentImageById(int apartmentImageId);



    }
}