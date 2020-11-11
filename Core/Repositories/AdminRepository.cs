using Core.Models;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public Task<User> GetUser()
        {
            var user = new User
            {
                FirstName = "FIRST",

                LastName = "LAST"
            };

            return Task.FromResult(user);
        }
    }
}