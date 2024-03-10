using SharedEntities.Models.DTO.Response;
using SharedEntities.Models.DTO.Response.SpecialRuleModels;

namespace UesrServices.Models;

/// <summary>
///     Банда
/// </summary>
public class BandResponse
{
    public long Id { get; set; }
    
    public long TypeId { get; set; }
    
    public string Name { get; set; }
    
    public int MaxCost { get; set; }
    
    public int CurrentCost { get; set; }
    
    public List<UnitResponse> CurrentUnits { get; set; }
    
    public List<UnitDto> Units { get; set; }
    
    public List<BandSpecialRuleDto> Rules { get; set; }
}