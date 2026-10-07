using AutoMapper;
using UsersApi.Data.Dtos;
using UsersApi.Domain.Models;

namespace UsersApi.Profiles;

    public class UserPeofile : Profile
    {
        public UserPeofile()
        {
            CreateMap<CreateUserDto, User>()
                .ForMember(dest => dest.DateOfBirth, opt => opt.Ignore());
            
            CreateMap<UserResponse, User>()
                .ForMember(dest => dest.DateOfBirth, opt => opt.Ignore());
        }
    }
