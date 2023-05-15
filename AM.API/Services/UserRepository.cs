using AM.API.DataTranferObjects;
using AM.API.Entities;
using Microsoft.AspNetCore.Identity;

namespace AM.API.Services
{
    public class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User>() 
        { 
            new User{guid=Guid.NewGuid(),FirstName="Vishwa",LastName="Chaudhary",Email="vishwa881@gmail.com",Password="Vishwa@1" },
            new User{guid=Guid.NewGuid() ,FirstName="Vishwajeet",LastName="Chaudhary",Email="vishwajeet881@gmail.com",Password="Vishwajeet@1" }
        };

        public User CreateUser(User user)
        {
            user.guid = Guid.NewGuid();
            users.Add(user);
            return user;
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(Guid guid)
        {

            var user= users.Find(x => x.guid == guid);
            return user;
            
        }
    }
}
