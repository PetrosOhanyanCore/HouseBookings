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
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersInFirstNameAsync(string firstName);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersNotInLastNameAsync(string lastName);
        Task<IEnumerable<ApplicationUser>> GetAllActiveUsersAsync();
        Task<int> CountAllActiveUsersAsync();
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersInCreatedTimeAsync(DateTime createdTime);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUSersInDeactivatedAsync(DateTime deactivatedTime);
        Task<ApplicationUser> GetApplicationUserInClientIdAsync(int clientId);
        Task<ApplicationUser> GetApplicationUserInPhoneNumberAsync(string phoneNumber);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUSersByAccesTokenAsync(string accesToken);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersByBirthDateAsync(DateTime birthDate);
        void CreateApplicationUserAsync(ApplicationUserDTO applicationUserDTO);
        void UpdateApplicationUserAsync(ApplicationUserDTO applicationUserDTO);
        void DeleteApplicationUserAsync(ApplicationUserDTO applicationUserDTO);
    }
}
