using AutoMapper;
using SharedEntities.Models.DTO.Request;
using UserEntities.Entities;

namespace UesrServices;

public class UserServiceMapperProfile : Profile
{
    public UserServiceMapperProfile()
    {
        CreateMap<UserRequestDto, UserEntity>()
            .ForMember( entity => entity.Login, opt => opt.MapFrom( src => src.Login ))
            .ForMember(entity => entity.Password, opt => opt.MapFrom( src => src.Password ));

    }
}