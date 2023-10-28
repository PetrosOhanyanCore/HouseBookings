using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Model;
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

        public void AddImage(ApartmentImageDTO imageDTO)
        {
            try
            {
                ApartmentImage image = _mapper.Map<ApartmentImage>(imageDTO);
                _imgRepository.Add(image);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void UpdateImage(ApartmentImageDTO imageDTO)
        {
            try
            {
                ApartmentImage image = _mapper.Map<ApartmentImage>(imageDTO);
                _imgRepository.Update(image);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void RemoveImage(int id)
        {
            try
            {
                var image = _imgRepository.Get(id);
                if (image != null)
                {
                    _imgRepository.Remove(image);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public IEnumerable<ApartmentImageDTO> GetAllImage()
        {
            try
            {
                var images = _imgRepository.GetAll();
                return _mapper.Map<IEnumerable<ApartmentImageDTO>>(images);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public ApartmentImageDTO GetImageById(int id)
        {
            try
            {
                var image = _imgRepository.Get(id);
                return _mapper.Map<ApartmentImageDTO>(image);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Task<ApartmentImageDTO> GetApartmentImageAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddApartmentImage(ApartmentImageDTO apartmentImageDTO)
        {
            throw new NotImplementedException();
        }
    }
}
