using Core.Responses;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IAdminService
    {
        Task<AdminUserResponse> GetUser();
    }
}