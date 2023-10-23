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
    internal class TranslationService : ITranslationService
    {
        private readonly ITranslationRepository _repository;
        private readonly IMapper _mapper;
        public TranslationService(ITranslationRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public int SwithLanguage(string language)
        {
           return _repository.SwitchLanguage(language);
        }
    }
}
