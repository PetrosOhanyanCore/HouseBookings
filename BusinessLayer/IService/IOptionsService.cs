using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IService
{
    public interface IOptionsService
    {
        Task AddOptionsAsync(OptionsDTO optionsDTO);
        Task UpdateOptionsAsync(OptionsDTO optionsDTO);
        Task RemoveOptionsAsync(int id);
        Task<OptionsDTO> GetOptionByIdAsync(int id);
    }
}