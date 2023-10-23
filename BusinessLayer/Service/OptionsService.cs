using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
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
    }
}
