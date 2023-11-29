using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class ApartmentImageService : IApartmentImageService
    {
        private readonly IApartmentImageRepository _imgRepository;
        private readonly IMapper _mapper;


        public ApartmentImageService(
            IApartmentImageRepository imageRepository,
            IMapper mapper)
        {
            _imgRepository = imageRepository;
            _mapper = mapper;
        }

        public void UpdateImage(ApartmentImageDTO imageDTO)
        {

            ApartmentImage image = _mapper.Map<ApartmentImage>(imageDTO);
            _imgRepository.Update(image);


        }


        public void RemoveApartmentImage(ApartmentImageDTO apartmentImageDTO)
        {
            ApartmentImage apartementImage = _mapper.Map<ApartmentImage>(apartmentImageDTO);
            _imgRepository.Remove(apartementImage);

        }


        public void RemoveApartmentImageById(int apartmentImageId)
        {
            ApartmentImage apartementImage = _mapper.Map<ApartmentImage>(apartmentImageId);
            _imgRepository.RemoveApartmentImageById(apartmentImageId);
        }


        public IEnumerable<ApartmentImageDTO> GetAllApartmentImages()
        {

            var images = _imgRepository.GetAll();
            return _mapper.Map<IEnumerable<ApartmentImageDTO>>(images);
        }


        public async Task<IEnumerable<ApartmentImageDTO>> GetAllApartmentImagesByApartmentIdAsync(int apartmentId)
        {
            var images = await _imgRepository.GetApartmentAllImagesAsync(apartmentId);
            return _mapper.Map<IEnumerable<ApartmentImageDTO>>(images);
        }
        public ApartmentImageDTO GetImageById(int id)
        {
            var image = _imgRepository.Get(id);
            return _mapper.Map<ApartmentImageDTO>(image);
        }

        public async Task<ApartmentImageDTO> GetApartmentImageByIdAsync(int apartmentId)
        {
            var image = await _imgRepository.GetAsync(apartmentId);
            return _mapper.Map<ApartmentImageDTO>(image);
        }

        public void AddApartmentImage(ApartmentImageDTO apartmentImageDTO)
        {
       
                ApartmentImage apartementImage = _mapper.Map<ApartmentImage>(apartmentImageDTO);
            _imgRepository.Add(apartementImage);
            
        }
       
    }
}
