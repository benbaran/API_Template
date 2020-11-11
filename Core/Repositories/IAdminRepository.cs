using Core.Models;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IAdminRepository
    {
        Task<User> GetUser();
    }
}