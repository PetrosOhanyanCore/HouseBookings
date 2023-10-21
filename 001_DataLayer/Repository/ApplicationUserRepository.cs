
using DataLayer.IRepository;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository
{
    internal class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(DataBaseContext context)
          : base(context)
        {
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInActiveAsync(bool isActive)
        {
           List<ApplicationUser> applicationUsers = await _context.ApplicationUsers
                .Where(x => x.IsActive == isActive)
                .ToListAsync();

            return applicationUsers;
        }
        public async Task<int> CountApplicationUsersByIsActiveAsync(bool isActive)
        {
            int count = await _context.ApplicationUsers.Where(x => x.IsActive == isActive).CountAsync();
            return count;
        }


        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInCreatedDateAsync(DateTime dateTime)
        {
            List<ApplicationUser> applicationUsers = await _context.ApplicationUsers.Where(a=>a.CreatedDate == dateTime).ToListAsync();
            return applicationUsers;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInDeactivationDateAsync(DateTime dateTime)
        {
            List<ApplicationUser> applicationUsers = await _context.ApplicationUsers.Where(a => a.DeactivationDate == dateTime).ToListAsync();
            return applicationUsers;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInLastNameAsync(string lastName)
        {
            List<ApplicationUser> applicationUsers = await _context.ApplicationUsers.Where(a => a.LastName.Equals(lastName)).ToListAsync();
            return applicationUsers;

        }

        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInNameAsync(string firstName)
        {
            List<ApplicationUser> applicationUsers = await _context.ApplicationUsers.Where(a => a.FirstName.Equals(firstName)).ToListAsync();
            return applicationUsers;
        }

        public async Task<ApplicationUser> GetApplicationUserInCleantIdAsync(int clientId)
        {
            ApplicationUser applicationUser = await _context.ApplicationUsers.FirstOrDefaultAsync(a => a.ClientId == clientId);

            return applicationUser;
        }
        public async Task<ApplicationUser> GetApplicationUsersInPhoneNumberAsync(string phoneNumber) 
        {
            ApplicationUser applicationUsers = await _context.ApplicationUsers.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
            
            return applicationUsers;
        }
        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInAccessTokenAsync(string accessToken)
        {
            List<ApplicationUser> applicationUsers = await _context.ApplicationUsers
                .Where(a => a.AccessToken == accessToken)
                .ToListAsync();
            return applicationUsers;
        }
        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUserByBirthDateAsync(DateTime birthDate)
        {
            List<ApplicationUser> applicationUsers = await _context.ApplicationUsers
                .Where(a => a.Client.BirthDate == birthDate)
                .ToListAsync();
            return applicationUsers;
        }



    }
}
