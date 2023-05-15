using AM.API.Entities;

namespace AM.API.Services
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        List<User> GetAllUsers();
        User GetUserById(Guid guid);
    }
}
