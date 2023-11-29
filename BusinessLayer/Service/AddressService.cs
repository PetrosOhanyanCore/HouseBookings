using AutoMapper;
using DataLayer;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using Model.DTO;
using Model.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IBuildingRepository _buildingRepository;
        private readonly IMapper _mapper;
        public AddressService(IAddressRepository addressRepository, IBuildingRepository buildingRepository, IMapper mapper)
        {
            this._addressRepository = addressRepository;
            this._mapper = mapper;
            this._buildingRepository = buildingRepository;
        }

        public async Task AddAddress(AddressVM addressVM)
        {
            try
            {
                var building = _buildingRepository.Get(addressVM.BuildingId);

                if (building == null)
                    throw new InvalidOperationException("Building not found");

                var dto = new AddressDTO
                {
                    City = addressVM.City,
                    Country = addressVM.Country,
                    District = addressVM.District,
                    House = addressVM.House,
                    Street = addressVM.Street,
                    Building = _mapper.Map<BuildingDTO>(building)
                };

                Address address = _mapper.Map<Address>(dto);
                _addressRepository.Add(address);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public async Task UpdateAddress(AddressVM addressVM)
        {
            try
            {
                var building = _buildingRepository.Get(addressVM.BuildingId);

                if (building == null)
                    throw new InvalidOperationException("Building not found");

                var dto = new AddressDTO
                {
                    City = addressVM.City,
                    Country = addressVM.Country,
                    District = addressVM.District,
                    House = addressVM.House,
                    Street = addressVM.Street,
                    Building = _mapper.Map<BuildingDTO>(building)
                };

                Address address = _mapper.Map<Address>(dto);
                _addressRepository.Update(address);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public async Task RemoveAddress(int id)
        {
            try
            {
                var address = _addressRepository.Get(id);
                if (address != null)
                {
                    _addressRepository.Remove(address);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public AddressDTO GetBuildingByAddressId(int id)
        {
            var building = _addressRepository.GetBuildingByAddressId(id);
            if (building == null)
            {
                return null;
            }
            var addressDTO = _mapper.Map<AddressDTO>(building);
            return addressDTO;
        }

        public async Task<AddressDTO> GetBuildingByAddressIdAsync(int id)
        {
            var building = await _addressRepository.GetBuildingByAddressIdAsync(id);
            if (building == null)
            {

                return null;
            }

            var addressDTO = _mapper.Map<AddressDTO>(building);
            return addressDTO;
        }

        public async Task<IEnumerable<AddressDTO>> GetBuildingsByCityAsync(string city)
        {

            var buildings = await _addressRepository.GetBuildingsByCityAsync(city);


            var addressDTOs = buildings.Select(building => _mapper.Map<AddressDTO>(building));

            return addressDTOs;
        }


        public async Task<IEnumerable<AddressDTO>> GetBuildingsByCountryAsync(string country)
        {
            var buildings = await _addressRepository.GetBuildingsByCountryAsync(country);


            var addressDTOs = buildings.Select(building => _mapper.Map<AddressDTO>(building));

            return addressDTOs;
        }


        public async Task<IEnumerable<AddressDTO>> GetBuildingsByDistrictAsync(string district)
        {

            var buildings = await _addressRepository.GetBuildingsByDistrictAsync(district);

            var addressDTOs = buildings.Select(building => _mapper.Map<AddressDTO>(building));

            return addressDTOs;
        }




        public async Task<IEnumerable<AddressDTO>> GetBuildingsByHouseTypeAsync(string house, string country)
        {
            var buildings = await _addressRepository.GetBuildingsByHouseTypeAsync(house, country);

            var addressDTOs = buildings.Select(building => _mapper.Map<AddressDTO>(building));

            return addressDTOs;
        }

        public async Task<int> GetBuildingsCountByCityAsync(string city)
        {

            int buildingCount = await _addressRepository.GetBuildingsCountByCityAsync(city);

            return buildingCount;
        }
    }
}



