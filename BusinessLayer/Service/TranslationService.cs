using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class TranslationService : ITranslationService
    {
        private readonly ITranslationRepository _translationRepository;
        private readonly IMapper _mapper;
        public TranslationService(ITranslationRepository translationRepository, IMapper mapper)
        {
            this._translationRepository = translationRepository;
            this._mapper = mapper;
        }

        public async Task AddTranslationAsync(TranslationDTO translationDTO)
        {
            var translation =_mapper.Map<Translation>(translationDTO);
            await _translationRepository.AddAsync(translation);
        }

        public async Task<IEnumerable<TranslationDTO>> GetAllTranslationAsync()
        {
            var translation = await _translationRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TranslationDTO>>(translation);

        }

        public async Task<TranslationDTO> GetTranslationByIdAsync(int id)
        {
            var translation = await _translationRepository.GetTranslationtByIdAsync(id);
            return _mapper.Map<TranslationDTO>(translation);

        }


        public async Task RemoveTranslationAsync(int id)
        {
            var translation = _translationRepository.Get(id);
            if (translation != null)
            {
                await _translationRepository.RemoveAsync(translation);
            }
        }

        public int SwithLanguage(string language)
        {
            return _translationRepository.SwitchLanguage(language);
        }

        public async Task UpdateTranslationAsync(TranslationDTO translationDTO)
        {
            var translation = _mapper.Map<Translation>(translationDTO);
            await _translationRepository.UpdateAsync(translation);

        }
        
    }
}

