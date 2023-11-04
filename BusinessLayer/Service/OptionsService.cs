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

        public Task AddOptionsAsync(OptionsDTO optionsDTO)
        {
                Options options = _mapper.Map<Options>(optionsDTO);
                _optionsRepository.Add(options);
                return Task.CompletedTask;

        }
        public Task UpdateOptionsAsync(OptionsDTO optionsDTO)
        {
                Options options = _mapper.Map<Options>(optionsDTO);
                _optionsRepository.Update(options);
                return Task.CompletedTask;

        }
        public Task RemoveOptionsAsync(int id)
        {
                var option = _optionsRepository.Get(id);
                if (option != null)
                {
                    _optionsRepository.Remove(option);
                }
                return Task.CompletedTask;

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
