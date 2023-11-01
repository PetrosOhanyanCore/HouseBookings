using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IService
{
    public interface ITranslationService
    {
        int SwithLanguage(string language);

        Task<TranslationDTO> GetTranslationtByIdAsync(int id);
        Task<IEnumerable<TranslationDTO>> GetAllTranslationAsync();

        Task AddTranslationAsync(TranslationDTO translationDTO);
        Task UpdateTranslationAsync(TranslationDTO translationDTO);
        Task RemoveTranslationAsync(int id);
    }
}
