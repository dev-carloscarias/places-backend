namespace Places.Application.Interfaces;

public interface IUserService : IService<User>
{
    Task OwnerRegistration(OwnerRegistrationDto owner);

    Task OwnerApprobation(OwnerApprobationDto owner);

    Task<User?> GetCurrentUser();

    Task<IEnumerable<User>> GetAllPendingOwners();

    Task<User> OwnerRegistrationById(int userId);
    Task<IEnumerable<User>> GetAdminUsers();
}