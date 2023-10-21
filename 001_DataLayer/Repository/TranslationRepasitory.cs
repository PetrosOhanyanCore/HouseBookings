using DataLayer.IRepository;
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
