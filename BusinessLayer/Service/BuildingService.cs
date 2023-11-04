using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class BuildingService : IBuildingService
    {

        private readonly IBuildingRepository _buildingRepositroy;
        private readonly IMapper _mapper;

        public BuildingService(IBuildingRepository buildingRepository, IMapper maper)
        {
            _buildingRepositroy = buildingRepository;
            _mapper = maper;
        }

        public void Add(BuildingDTO buildingdto)
        {
            Building building = _mapper.Map<Building>(buildingdto) ;
            _buildingRepositroy.Add(building);
        }

        public void AddRange(IEnumerable<BuildingDTO> buildingdtos)
        {
            List<Building> list = new List<Building>();

            foreach (var item in buildingdtos)
            {
                var dto = _mapper.Map<Building>(item);
                list.Add(dto);
            }

            _buildingRepositroy.AddRange(list);
        }

        public IEnumerable<BuildingDTO> GetAllBuildings(int locationId)
        {
            var buildings = (List<BuildingDTO>)_buildingRepositroy.GetAllBuildings(locationId);

            return buildings;

        }

        

        public async Task<BuildingDTO> GetBuildingById(int buildingId)
        {
            var result = await _buildingRepositroy.GetBuildingByIdAsync(buildingId);
            return _mapper.Map<Building, BuildingDTO>(result);
        }



        public int ImagesCountByImageId(int id)
        {
            return _buildingRepositroy.ImagesCountByImageId(id);
        }

        public void Remove(BuildingDTO entity)
        {
            var building = _mapper.Map<Building>(entity);
            _buildingRepositroy.Remove(building);
        }

        public void RemoveRange(IEnumerable<BuildingDTO> entities)
        {
            List<Building> list = new List<Building>();
            foreach (var entity in entities)
            {
                var dto = _mapper.Map<Building>(entity);
                list.Add(dto);
            }
            _buildingRepositroy.RemoveRange(list);
        }
        
       

        public void Update(BuildingDTO entity)
        {
            var building= _mapper.Map<Building>(entity);
            _buildingRepositroy.Update(building);
        }

        public void UpdateRange(IEnumerable<BuildingDTO> entities)
        {
            List<Building> list = new List<Building>();
            foreach(var entity in entities)
            {
                var dto= _mapper.Map<Building>(entity);
                list.Add(dto);
            }
            _buildingRepositroy.UpdateRange(list);
        }
    }
}
