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
    internal class BuildingService : IBuildingService

    {

        private readonly IBuildingRepository _buildingRepositroy;
        private readonly IMapper _mapper;

        public BuildingService(IBuildingRepository buildingRepository, IMapper maper)
        {
            _buildingRepositroy = buildingRepository;
            _mapper = maper;
        }

        public  IEnumerable<BuildingDTO> GetAllBuildings(int locationId)
        {
           var buildings = (List<BuildingDTO>)_buildingRepositroy.GetAllBuildings(locationId);

            return buildings;

        }

        public async Task<BuildingDTO> GetBuildingById(int buildingId)
        {
            var result =  await _buildingRepositroy.GetBuildingByIdAsync(buildingId);
            return _mapper.Map<Building, BuildingDTO>(result);
        }



        public int ImagesCountByImageId(int id)
        {
            return _buildingRepositroy.ImagesCountByImageId(id);
        }
    }
}
