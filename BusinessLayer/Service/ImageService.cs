using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imgRepository;
        private readonly IMapper _mapper;


        public ImageService(
            IImageRepository imageRepository,
            IMapper mapper)
        {
            _imgRepository = imageRepository;
            _mapper = mapper;
        }

        public void AddImage(ImageDTO imageDTO)
        {
            try
            {
                Image<Type> image = _mapper.Map<Image<Type>>(imageDTO);
                _imgRepository.Add(image);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void UpdateImage(ImageDTO imageDTO)
        {
            try
            {
                Image<Type> image = _mapper.Map<Image<Type>>(imageDTO);
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
        public IEnumerable<ImageDTO> GetAllImage()
        {
            try
            {
                var images = _imgRepository.GetAll();
                return _mapper.Map<IEnumerable<ImageDTO>>(images);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public ImageDTO GetImageById(int id)
        {
            try
            {
                var image = _imgRepository.Get(id);
                return _mapper.Map<ImageDTO>(image);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
