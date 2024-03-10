using AutoMapper;
using RuleEntities.Entities;
using RuleServices.Models;
using RuleServices.Models.Dto.Response;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Mappers;

public class RuleMapperProfile : Profile
{
    public RuleMapperProfile()
    {
        CreateMap<BandEntity, BandModel>()
            .ForMember(s => s.Id, m => m.MapFrom(d => d.Id))
            .ForMember(s => s.Name, m => m.MapFrom(d => d.Name))
            .ForMember(s => s.Units, m => m.MapFrom(d => d.Units));

        CreateMap<UnitEntity, UnitDto>()
            .ForMember(s => s.Id, m => m.MapFrom(d => d.Name))
            .ForMember(s => s.Name, m => m.MapFrom(d => d.Name));

        CreateMap<ArmorEntity, ArmorDto>()
            .ForMember(s => s.Id, m => m.MapFrom(d => d.Id))
            .ForMember(s => s.Name, m => m.MapFrom(d => d.Name))
            .ForMember(s => s.Description, m => m.MapFrom(d => d.Description))
            .ForMember(s => s.Rules, m => m.MapFrom(d => d.Rules.ToArray()));


    }
    
}