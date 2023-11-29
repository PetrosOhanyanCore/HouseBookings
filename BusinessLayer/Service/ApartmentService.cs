using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model.DTO;

namespace BusinessLayer.Service
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IMapper _mapper;


        public ApartmentService(
            IApartmentRepository apartmentRepository, 
            IMapper mapper)
        {
            _apartmentRepository = apartmentRepository;
            _mapper = mapper;
        }

        public void AddApartment(ApartmentDTO apartment)
        {
            var apartmentEntity = _mapper.Map<Apartment>(apartment);
            _apartmentRepository.Add(apartmentEntity);
        }

        public async Task AddApartmentAsync(ApartmentDTO apartment)
        {
            var apartmentEntity = _mapper.Map<Apartment>(apartment);
            await _apartmentRepository.AddApartmentAsync(apartmentEntity);
        }

        public void DeleteApartment(ApartmentDTO apartment)
        {
            var apartmentEntity = _mapper.Map<Apartment>(apartment);
            _apartmentRepository.Remove(apartmentEntity);
        }

        public async Task DeleteApartmentAsync(ApartmentDTO apartment)
        {
            var apartmentEntity = _mapper.Map<Apartment>(apartment);
            await _apartmentRepository.DeleteApartmentAsync(apartmentEntity);
        }

        public IEnumerable<ApartmentDTO> GetAllApartments(int buildingId)
        {
            var apartments = _apartmentRepository.GetAllApartments(buildingId);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetAllApartmentsAsync(int buildingId)
        {
            var apartments = await _apartmentRepository.GetAllApartmentsAsync(buildingId);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<ApartmentDTO> GetApartmentByIdAsync(int id)
        {
            var apartment = await _apartmentRepository.GetApartmentByIdAsync(id);
            return _mapper.Map<ApartmentDTO>(apartment);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByBalconyCountAsync(int count)
        {
            var apartments = await _apartmentRepository.GetApartmentsByBalconyCountAsync(count);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByBuildingIdAsync(int buildingId)
        {
            var apartments = await _apartmentRepository.GetApartmentsByBuildingIdAsync(buildingId);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByFloorAsync(int floor)
        {
            var apartments = await _apartmentRepository.GetApartmentsByFloorAsync(floor);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByFloorCountAsync(int floorCount)
        {
            var apartments = await _apartmentRepository.GetApartmentsByFloorCountAsync(floorCount);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByFloorHeightAsync(double floorHeight)
        {
            var apartments = await _apartmentRepository.GetApartmentsByFloorHeightAsync(floorHeight);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByKitchenAreaAsync(double area)
        {
            var apartments = await _apartmentRepository.GetApartmentsByKitchenAreaAsync(area);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByLivingRoomAreaAsync(double area)
        {
            var apartments = await _apartmentRepository.GetApartmentsByLivingRoomAreaAsync(area);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByNumberAsync(string number)
        {
            var apartments = await _apartmentRepository.GetApartmentsByNumberAsync(number);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            var apartments = await _apartmentRepository.GetApartmentsByPriceRangeAsync(minPrice, maxPrice);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByRoomsCountAsync(int roomsCount)
        {
            var apartments = await _apartmentRepository.GetApartmentsByRoomsCountAsync(roomsCount);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsBySectionAsync(string section)
        {
            var apartments = await _apartmentRepository.GetApartmentsBySectionAsync(section);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsByTranslationIdAsync(int translationId)
        {
            var apartments = await _apartmentRepository.GetApartmentsByTranslationIdAsync(translationId);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }
        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsWithAttachedKitchenAsync()
        {
            var apartments = await _apartmentRepository.GetApartmentsWithAttachedKitchenAsync();
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsWithOptionAsync(string optionName)
        {
            var apartments = await _apartmentRepository.GetApartmentsWithOptionAsync(optionName);
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetApartmentsWithParkingSpaceAsync()
        {
            var apartments = await _apartmentRepository.GetApartmentsWithParkingSpaceAsync();
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

   

        public async Task<IEnumerable<ApartmentDTO>> GetAvailableApartmentsAsync()
        {
            var apartments = await _apartmentRepository.GetAvailableApartmentsAsync();
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<ICollection<ApartmentImageDTO>> GetImagesAsync(int apartmentId)
        {
            var images = await _apartmentRepository.GetImagesAsync(apartmentId);
            return _mapper.Map<ICollection<ApartmentImageDTO>>(images);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetPenthouseApartmentsAsync()
        {
            var apartments = await _apartmentRepository.GetPenthouseApartmentsAsync();
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public async Task<IEnumerable<ApartmentDTO>> GetStudioApartmentsAsync()
        {
            var apartments = await _apartmentRepository.GetStudioApartmentsAsync();
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }
      

     
        public async Task<IEnumerable<ApartmentDTO>> GetTownhouseApartmentsAsync()
        {
            var apartments = await _apartmentRepository.GetTownhouseApartmentsAsync();
            return _mapper.Map<IEnumerable<ApartmentDTO>>(apartments);
        }

        public int ImagesCountByImageId(int id)
        {
            var imagesCount = _apartmentRepository.ImagesCountByImageId(id);
            return imagesCount;
        }

        public async Task<int> ImagesCountByImageIdAsync(int buildingId)
        {
            var imagesCount = await _apartmentRepository.ImagesCountByImageIdAsync(buildingId);
            return imagesCount;
        }

        public async Task<bool> IsApartmentAvailableAsync(int apartmentId)
        {
            var isAvailable = await _apartmentRepository.IsApartmentAvailableAsync(apartmentId);
            return isAvailable;
        }
        
        public void UpdateApartment(ApartmentDTO apartment)
        {
            var exitApartment = _apartmentRepository.Get(apartment.Id);
            if(exitApartment != null)
            {
                var apartmentEntity = _mapper.Map<Apartment>(apartment);
                _apartmentRepository.Update(apartmentEntity);
            }
            else
            {
                throw new ArgumentException("Apartment does not exist.", nameof(ApartmentDTO));
            }
        }

        public async Task UpdateApartmentAsync(ApartmentDTO apartment)
        {
            var exitApartment = await _apartmentRepository.GetAsync(apartment.Id);
            if (exitApartment != null)
            {
                var apartmentEntity = _mapper.Map<Apartment>(apartment);
                await _apartmentRepository.UpdateApartmentAsync(apartmentEntity);
            }
            else
            {
                throw new ArgumentException("Apartment does not exist.", nameof(ApartmentDTO));
            }
        }
    }
}
