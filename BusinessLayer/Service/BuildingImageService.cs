using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Model;

namespace BusinessLayer.Service
{
    public class BuildingImageService : IBuildingImageService
    {
        private readonly IBuildingImageRepository _buildingImageRepository;
        private readonly IMapper _mapper;

        public BuildingImageService(IBuildingImageRepository buildingImageRepository, IMapper mapper)
        {
            _buildingImageRepository = buildingImageRepository;
            _mapper = mapper;
        }

        public void AddBuildingImage(BuildingImageDTO buildingImageDTO)
        {
            BuildingImage buildingImage = _mapper.Map<BuildingImage>(buildingImageDTO);
            _buildingImageRepository.Add(buildingImage);
        }

        public void AddRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs)
        {
            ICollection<BuildingImage> buildingImage = _mapper.Map<ICollection<BuildingImage>>(buildingImageDTOs);
            _buildingImageRepository.AddRange(buildingImage);
        }

        public IEnumerable<BuildingImageDTO> Find(Expression<Func<BuildingImage, bool>> predicate)
        {
            var buildingImage = _buildingImageRepository.Find(predicate);
            return _mapper.Map<IEnumerable<BuildingImageDTO>>(buildingImage);
        }

        public async Task<ICollection<BuildingImageDTO>> GetBuildingAllImagesAsync(int buildingId)
        {
           var buildingImages = await _buildingImageRepository.GetBuildingImageByIdAsync(buildingId);
            return _mapper.Map<ICollection<BuildingImageDTO>>(buildingImages);
        }

        public BuildingImageDTO GetBuildingImageById(int id)
        {
            var buildingImages =  _buildingImageRepository.Get(id);
            return _mapper.Map<BuildingImageDTO>(buildingImages);
        }

        public async Task<BuildingImageDTO> GetBuildingImageByIdAsync(int id)
        {
            var buildingImages = await _buildingImageRepository.GetAsync(id);
            return _mapper.Map<BuildingImageDTO>(buildingImages);
        }

        public void RemoveBuildingImage(BuildingImageDTO buildingImageDTO)
        {
            BuildingImage buildingImage = _mapper.Map<BuildingImage>(buildingImageDTO);
            _buildingImageRepository.Remove(buildingImage);
        }

        public void RemoveRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs)
        {
            ICollection<BuildingImage> buildingImage = _mapper.Map<ICollection<BuildingImage>>(buildingImageDTOs);
            _buildingImageRepository.RemoveRange(buildingImage);
        }

        public void UpdateBuildingImage(BuildingImageDTO buildingImageDTO)
        {
            BuildingImage buildingImage = _mapper.Map<BuildingImage>(buildingImageDTO);
            _buildingImageRepository.Update(buildingImage);
        }

        public void UpdateRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs)
        {
            ICollection<BuildingImage> buildingImages = _mapper.Map<ICollection<BuildingImage>>(buildingImageDTOs);
            _buildingImageRepository.UpdateRange(buildingImages);
        }
    }
}
