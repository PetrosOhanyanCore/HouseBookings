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
    public class OptionsService : IOptionsService
    {
        private readonly IOptionsRepository _optionsRepository;
        private readonly IMapper _mapper;


        public OptionsService(
            IOptionsRepository optionsRepository,
            IMapper mapper)
        {
            _optionsRepository = optionsRepository;
            _mapper = mapper;
        }

        public void AddOptions(OptionsDTO optionsDTO)
        {
            try
            {
                Options options = _mapper.Map<Options>(optionsDTO);
                _optionsRepository.Add(options);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void UpdateOptions(OptionsDTO optionsDTO)
        {
            try
            {
                Options options = _mapper.Map<Options>(optionsDTO);
                _optionsRepository.Update(options);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void RemoveOptions(int id)
        {
            try
            {
                var option = _optionsRepository.Get(id);
                if (option != null)
                {
                    _optionsRepository.Remove(option);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<OptionsDTO> GetOptionByIdAsync(int id)
        {
            try
            {
                var option = await _optionsRepository.GetOptionByIdAsync(id);
                return _mapper.Map<OptionsDTO>(option);
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }
    }
}
