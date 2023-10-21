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

    }
}
