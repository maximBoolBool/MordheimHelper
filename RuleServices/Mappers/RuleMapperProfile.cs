using AutoMapper;
using RuleEntities.Entities;
using RuleServices.Models;

namespace RuleServices.Mappers;

public class RuleMapperProfile : Profile
{
    public RuleMapperProfile()
    {
        CreateMap<BandEntity, BandModel>()
            .ForMember(s => s.Id, m => m.MapFrom(d => d.Name))
            .ForMember(s => s.Name, m => m.MapFrom(d => d.Name))
            .ForMember(s => s.Units, m => m.MapFrom(d => d.Units));

        CreateMap<UnitEntity, UnitModel>()
            .ForMember(s => s.Id, m => m.MapFrom(d => d.Name))
            .ForMember(s => s.Name, m => m.MapFrom(d => d.Name));
    }
    
}