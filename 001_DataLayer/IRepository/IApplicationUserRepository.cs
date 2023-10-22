using Entity;

namespace DataLayer.IRepository
{
    public interface IApplicationUserRepository:IRepositoryBase<ApplicationUser>
    {
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInNameAsync(string firstName);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInLastNameAsync(string lastName);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInActiveAsync(bool isActive);
        Task<int> CountApplicationUsersByIsActiveAsync(bool isActive);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInCreatedDateAsync(DateTime dateTime);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInDeactivationDateAsync(DateTime dateTime);
        Task<ApplicationUser> GetApplicationUserInCleantIdAsync(int clientId);
        Task<ApplicationUser> GetApplicationUsersInPhoneNumberAsync(string phoneNumber);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUserInAccessTokenAsync(string accessToken);
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUserByBirthDateAsync(DateTime birthDate);


    }
}
