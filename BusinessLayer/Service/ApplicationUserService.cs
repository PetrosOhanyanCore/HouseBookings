using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IMapper _mapper;

        public ApplicationUserService(IApplicationUserRepository applicationUserRepository,IMapper mapper)
        {
            _applicationUserRepository = applicationUserRepository;
            _mapper = mapper;
        }
        public void CreateApplicationUserAsync(ApplicationUserDTO applicationUserDTO)
        {
            var appUser = _mapper.Map<ApplicationUserDTO,ApplicationUser>(applicationUserDTO);
             _applicationUserRepository.Add(appUser);
        }
        public void UpdateApplicationUserAsync(ApplicationUserDTO applicationUserDTO)
        {
            var appUser = _mapper.Map<ApplicationUserDTO, ApplicationUser>(applicationUserDTO);
             _applicationUserRepository.Update(appUser);
        }

        public void DeleteApplicationUserAsync(ApplicationUserDTO applicationUserDTO)
        {
            var appUser = _mapper.Map<ApplicationUserDTO, ApplicationUser>(applicationUserDTO);
            if(appUser != null)
            {
                _applicationUserRepository.Remove(appUser);
            }
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllActiveUsersAsync()
        {
            var appActiveUsers = await _applicationUserRepository.GetAllApplicationUserInActiveAsync(true);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appActiveUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUSersByAccesTokenAsync(string accesToken)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInAccessTokenAsync(accesToken);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersByBirthDateAsync(DateTime birthDate)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserByBirthDateAsync(birthDate);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInCreatedTimeAsync(DateTime createdTime)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInCreatedDateAsync(createdTime);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUSersInDeactivatedAsync(DateTime deactivatedTime)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInDeactivationDateAsync(deactivatedTime);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInFirstNameAsync(string firstName)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInNameAsync(firstName);
            return _mapper.Map<IEnumerable<ApplicationUser>,IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInLastNameAsync(string lastName)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInLastNameAsync(lastName);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<ApplicationUserDTO> GetApplicationUserInClientIdAsync(int clientId)
        {
            var appUsers = await _applicationUserRepository.GetApplicationUserInCleantIdAsync(clientId);
            return _mapper.Map<ApplicationUser, ApplicationUserDTO>(appUsers);
        }

        public async Task<ApplicationUserDTO> GetApplicationUserInPhoneNumberAsync(string phoneNumber)
        {
            var appUsers = await _applicationUserRepository.GetApplicationUsersInPhoneNumberAsync(phoneNumber);
            return _mapper.Map<ApplicationUser, ApplicationUserDTO>(appUsers);
        }
        public async Task<int> CountAllActiveUsersAsync()
        {
            return await _applicationUserRepository.CountApplicationUsersByIsActiveAsync(true);
        }
    }
}
