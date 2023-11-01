using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
        public interface ITranslationRepository : IRepositoryBase<Translation>
        {

             //Id              Name             En             Rus              Arm 
        int SwitchLanguage(string language);

        Task<Translation> GetTranslationtByIdAsync(int id);
        Task<IEnumerable<Translation>> GetAllAsync();
        Task AddAsync(Translation translation);
        Task RemoveAsync(Translation translation);
        Task UpdateAsync(Translation translation);

    }
}
