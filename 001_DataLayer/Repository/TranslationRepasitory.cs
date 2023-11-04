using DataLayer;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class TranslationRepository
        : RepositoryBase<Translation>,
        ITranslationRepository
    {
        public TranslationRepository(DataBaseContext context) : base(context)
        {

        }

        public async Task AddAsync(Translation translation)
        {
            await _context.Translations.AddAsync(translation);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Translation>> GetAllAsync()
        {
            return await _context.Translations.ToListAsync();
        }

        public async Task<Translation> GetTranslationtByIdAsync(int id)
        {
            var result = await _context.Translations.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public async Task RemoveAsync(Translation translation)
        {
            _context.Translations.Remove(translation);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Translation translation)
        {
            _context.Translations.Update(translation);
            await _context.SaveChangesAsync();
        }
        public int SwitchLanguage(string language)
        {
            int languageCode;

            switch (language)
            {
                case "English":
                    languageCode = 1;
                    break;

                case "Armenian":
                    languageCode = 2;
                    break;

                case "Russian":
                    languageCode = 3;
                    break;

                // Add more cases for other languages as needed

                default:
                    languageCode = 0; // Default language code for unknown languages
                    break;
            }

            return languageCode;
        }
    }
}
