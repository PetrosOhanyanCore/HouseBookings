
using Model;

namespace BusinessLayer.IService
{
    public interface IApartmentService
    {
        void AddApartment(ApartmentDTO apartment);
        void UpdateApartment(ApartmentDTO apartment);
        void DeleteApartment(ApartmentDTO apartment);

        Task<ApartmentDTO> GetApartmentByIdAsync(int id);
        IEnumerable<ApartmentDTO> GetAllApartments(int buildingId);
        int ImagesCountByImageId(int id);
        Task<ICollection<ApartmentImageDTO>> GetImagesAsync(int apartmentId);
        Task<IEnumerable<ApartmentDTO>> GetAllApartmentsAsync(int buildingId);
        Task<int> ImagesCountByImageIdAsync(int buildingId);
        Task AddApartmentAsync(ApartmentDTO apartment);
        Task UpdateApartmentAsync(ApartmentDTO apartment);
        Task DeleteApartmentAsync(ApartmentDTO apartment);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByPriceRangeAsync(decimal minPrice, decimal maxPrice);
        Task<IEnumerable<ApartmentDTO>> GetAvailableApartmentsAsync();
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByRoomsCountAsync(int roomsCount);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByTranslationIdAsync(int translationId);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByBuildingIdAsync(int buildingId);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsBySectionAsync(string section);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByNumberAsync(string number);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByFloorAsync(int floor);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByFloorCountAsync(int floorCount);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByFloorHeightAsync(double floorHeight);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsWithParkingSpaceAsync();
        Task<IEnumerable<ApartmentDTO>> GetPenthouseApartmentsAsync();
        Task<IEnumerable<ApartmentDTO>> GetStudioApartmentsAsync();
        Task<IEnumerable<ApartmentDTO>> GetTownhouseApartmentsAsync();
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByLivingRoomAreaAsync(double area);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByKitchenAreaAsync(double area);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsWithAttachedKitchenAsync();
        Task<IEnumerable<ApartmentDTO>> GetApartmentsByBalconyCountAsync(int count);
        Task<bool> IsApartmentAvailableAsync(int apartmentId);
        Task<IEnumerable<ApartmentDTO>> GetApartmentsWithOptionAsync(string optionName);



    }
}
