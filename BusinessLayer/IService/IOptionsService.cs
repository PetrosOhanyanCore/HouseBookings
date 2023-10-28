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
        void AddOptions(OptionsDTO optionsDTO);
        void UpdateOptions(OptionsDTO optionsDTO);
        void RemoveOptions(int id);
        Task<OptionsDTO> GetOptionByIdAsync(int id);
    }
}