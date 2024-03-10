using AutoMapper;
using SharedEntities.Models.DTO.Request;
using UesrServices.Models.Requests;
using UserEntities.Entities;

namespace UesrServices;

public class UserServiceMapperProfile : Profile
{
    public UserServiceMapperProfile()
    {
        CreateMap<UserQueryDto, UserEntity>()
            .ForMember( entity => entity.Login, opt => opt.MapFrom( src => src.Login ))
            .ForMember(entity => entity.Password, opt => opt.MapFrom( src => src.Password ));

        CreateMap<CreateBandRequest, BandEntity>()
            .ForMember(e => e.Name, m => m.MapFrom(s => s.Name))
            .ForMember(e => e.RuleId, m => m.MapFrom(s => s.TypeId))
            .ForMember(e => e.MaxPointCost, m => m.MapFrom(s => s.BandCostLimit));
    }
}