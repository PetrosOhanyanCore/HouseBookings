using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IApartmentRepository: IRepositoryBase<Apartment>
    {
        /// <summary>
        /// Get ApartmentById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Apartment> GetApartmentByIdAsync(int id);

        /// <summary>
        /// Return all building's apartments
        /// </summary>
        /// <param name="buildingId"></param>
        /// <returns></returns>
        IEnumerable<Apartment> GetAllApartments(int buildingId);

        /// <summary>
        /// Return Apartment Images Count
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int ImagesCountByImageId(int id);

        /// <summary>
        /// Return Apartment Images
        /// </summary>
        /// <param name="apartmentId"></param>
        /// <returns></returns>
        Task<ICollection<Image>> GetImages(int apartmentId);
    }
}
