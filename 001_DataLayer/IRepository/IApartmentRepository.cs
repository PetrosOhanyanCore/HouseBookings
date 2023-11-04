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
        Task<ICollection<ApartmentImage>> GetImagesAsync(int apartmentId);
        /// <summary>
        /// Get all apartments in a building asynchronously.
        /// </summary>
        /// <param name="buildingId">The ID of the building.</param>
        /// <returns>A collection of all apartments in the specified building.</returns
        Task<IEnumerable<Apartment>> GetAllApartmentsAsync(int buildingId);
        /// <summary>
        /// Get the count of images associated with an apartment asynchronously.
        /// </summary>
        /// <param name="buildingId">The ID of the apartment.</param>
        /// <returns>The count of images associated with the apartment.</returns>
        Task<int> ImagesCountByImageIdAsync(int buildingId);
        /// <summary>
        /// Add an apartment asynchronously.
        /// </summary>
        /// <param name="apartment">The apartment to add.</param>
        Task AddApartmentAsync(Apartment apartment);
        
        /// <summary>
        /// Update an apartment asynchronously.
        /// </summary>
        /// <param name="apartment">The apartment to update.</param>

        Task UpdateApartmentAsync(Apartment apartment);
        
        /// <summary>
        /// Delete an apartment asynchronously.
        /// </summary>
        /// <param name="apartment">The apartment to delete.</param>
        Task DeleteApartmentAsync(Apartment apartment);
        /// <summary>
        /// Get apartments within a price range asynchronously.
        /// </summary>
        /// <param name="minPrice">The minimum price.</param>
        /// <param name="maxPrice">The maximum price.</param>
        /// <returns>A collection of apartments within the specified price range.</returns
        Task<IEnumerable<Apartment>> GetApartmentsByPriceRangeAsync(decimal minPrice, decimal maxPrice);
        /// <summary>
        /// Get available apartments asynchronously.
        /// </summary>
        /// <returns>A collection of available apartments.</returns>
        Task<IEnumerable<Apartment>> GetAvailableApartmentsAsync();
        /// <summary>
        /// Get apartments based on the number of rooms asynchronously.
        /// </summary>
        /// <param name="roomsCount">The number of rooms.</param>
        /// <returns>A collection of apartments with the specified number of rooms.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByRoomsCountAsync(int roomsCount);
        /// <summary>
        /// Get apartments by translation ID asynchronously.
        /// </summary>
        /// <param name="translationId">The ID of the translation.</param>
        /// <returns>A collection of apartments with the specified translation ID.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByTranslationIdAsync(int translationId);
        /// <summary>
        /// Get apartments by building ID asynchronously.
        /// </summary>
        /// <param name="buildingId">The ID of the building.</param>
        /// <returns>A collection of apartments in the specified building.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByBuildingIdAsync(int buildingId);
        /// <summary>
        /// Get apartments by section asynchronously.
        /// </summary>
        /// <param name="section">The section of the apartments.</param>
        /// <returns>A collection of apartments in the specified section.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsBySectionAsync(string section);
        /// <summary>
        /// Get apartments by number asynchronously.
        /// </summary>
        /// <param name="number">The number of the apartments.</param>
        /// <returns>A collection of apartments with the specified number.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByNumberAsync(string number);
        /// <summary>
        /// Get apartments by floor asynchronously.
        /// </summary>
        /// <param name="floor">The floor of the apartments.</param>
        /// <returns>A collection of apartments on the specified floor.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByFloorAsync(int floor);
        /// <summary>
        /// Get apartments by floor count asynchronously.
        /// </summary>
        /// <param name="floorCount">The count of floors in the apartments.</param>
        /// <returns>A collection of apartments with the specified floor count.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByFloorCountAsync(int floorCount);
        /// <summary>
        /// Get apartments by floor height asynchronously.
        /// </summary>
        /// <param name="floorHeight">The floor height of the apartments.</param>
        /// <returns>A collection of apartments with the specified floor height.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByFloorHeightAsync(double floorHeight);
        /// <summary>
        /// Get apartments with parking space asynchronously.
        /// </summary>
        /// <returns>A collection of apartments with parking space.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsWithParkingSpaceAsync();
        /// <summary>
        /// Get penthouse apartments asynchronously.
        /// </summary>
        /// <returns>A collection of penthouse apartments.</returns>
        Task<IEnumerable<Apartment>> GetPenthouseApartmentsAsync();
        /// <summary>
        /// Get studio apartments asynchronously.
        /// </summary>
        /// <returns>A collection of studio apartments.</returns>
        Task<IEnumerable<Apartment>> GetStudioApartmentsAsync();

        /// <summary>
        /// Get townhouse apartments asynchronously.
        /// </summary>
        /// <returns>A collection of townhouse apartments.</returns>
        Task<IEnumerable<Apartment>> GetTownhouseApartmentsAsync();
        /// <summary>
        /// Get apartments by living room area asynchronously.
        /// </summary>
        /// <param name="area">The area of the living room.</param>
        /// <returns>A collection of apartments with the specified living room area.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByLivingRoomAreaAsync(double area);
        /// <summary>
        /// Get apartments by kitchen area asynchronously.
        /// </summary>
        /// <param name="area">The area of the kitchen.</param>
        /// <returns>A collection of apartments with the specified kitchen area.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByKitchenAreaAsync(double area);
        /// <summary>
        /// Get apartments with attached kitchen asynchronously.
        /// </summary>
        /// <returns>A collection of apartments with an attached kitchen.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsWithAttachedKitchenAsync();
        /// <summary>
        /// Get apartments by balcony count asynchronously.
        /// </summary>
        /// <param name="count">The count of balconies.</param>
        /// <returns>A collection of apartments with the specified balcony count.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsByBalconyCountAsync(int count);
        /// <summary>
        /// Check if an apartment is available asynchronously.
        /// </summary>
        /// <param name="apartmentId">The ID of the apartment.</param>
        /// <returns>True if the apartment is availableAsync(int apartmentId);

        Task<bool> IsApartmentAvailableAsync(int apartmentId);

        /// <summary>
        /// Get apartments with a specific option asynchronously.
        /// </summary>
        /// <param name="optionName">The name of the option.</param>
        /// <returns>A collection of apartments with the specified option.</returns>
        Task<IEnumerable<Apartment>> GetApartmentsWithOptionAsync(string optionName);

    }
}
