using SharedEntities.Models.DTO.Response;
using SharedEntities.Models.DTO.Response.SpecialRuleModels;

namespace RuleServices.Models.Dto.Response;

public class BandModel
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public UnitDto[] Units { get; set; }
    
    public BandSpecialRuleDto[] Rules { get; set; }
}