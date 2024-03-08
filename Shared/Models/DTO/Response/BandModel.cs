using SharedEntities.Models.DTO.Response;

namespace RuleServices.Models;

public class BandModel
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public UnitResponse[] Units { get; set; }
}