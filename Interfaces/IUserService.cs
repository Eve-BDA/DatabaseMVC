using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseMVC.Models;

namespace DatabaseMVC.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
