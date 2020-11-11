using AutoMapper;
using Core.Models;
using Core.Responses;

namespace Core.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, AdminUserResponse>().ForMember(
        dest => dest.FullName,
        opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));
        }
    }
}