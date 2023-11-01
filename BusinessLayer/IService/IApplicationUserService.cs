using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IService
{
    public interface IApplicationUserService
    {
        Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInFirstNameAsync(string firstName);
        Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInLastNameAsync(string lastName);
        Task<IEnumerable<ApplicationUserDTO>> GetAllActiveUsersAsync();
        Task<int> CountAllActiveUsersAsync();
        Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInCreatedTimeAsync(DateTime createdTime);
        Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUSersInDeactivatedAsync(DateTime deactivatedTime);
        Task<ApplicationUserDTO> GetApplicationUserInClientIdAsync(int clientId);
        Task<ApplicationUserDTO> GetApplicationUserInPhoneNumberAsync(string phoneNumber);
        Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUSersByAccesTokenAsync(string accesToken);
        Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersByBirthDateAsync(DateTime birthDate);
        Task<ApplicationUser> GetById(string id);
        void CreateApplicationUserAsync(ApplicationUserDTO applicationUserDTO);
        void UpdateApplicationUserAsync(ApplicationUserDTO applicationUserDTO);
        void DeleteApplicationUserAsync(ApplicationUserDTO applicationUserDTO);
    }
}
