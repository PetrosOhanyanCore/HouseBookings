using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IService
{
    public interface IApartmentImageService
    {
        Task<ApartmentImageDTO> GetApartmentImageAsync();
        Task AddApartmentImage(ApartmentImageDTO apartmentImageDTO);
    }
}
