using EducationalResourceAPI.Models;
using System.Threading.Tasks;

namespace EducationalResourceAPI.Services
{
    public interface IUserService
    {
        Task<User> Register(User user);
        Task<User?> Authenticate(string email, string password);
    }
}
