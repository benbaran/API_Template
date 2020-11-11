using AutoMapper;
using Core.Repositories;
using Core.Responses;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repository;

        private readonly IMapper _mapper;

        public AdminService(IAdminRepository repository, IMapper mapper)
        {
            _repository = repository;

            _mapper = mapper;
        }

        public async Task<AdminUserResponse> GetUser()
        {
            var user = await _repository.GetUser();

            AdminUserResponse response = _mapper.Map<AdminUserResponse>(user);

            return response;
        }
    }
}