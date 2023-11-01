using Entity;
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
        void RemoveApartmentImage(ApartmentImageDTO apartmentImageDTO );

        void RemoveApartmentImageById(int ApartmentImageId );

        void UpdateImage(ApartmentImageDTO imageDTO);
        Task<IEnumerable<ApartmentImageDTO>> GetAllApartmentImagesByApartmentIdAsync(int apartmentId);
        void AddApartmentImage(ApartmentImageDTO apartmentImageDTO);

        IEnumerable<ApartmentImageDTO> GetAllApartmentImages();
    }
}
