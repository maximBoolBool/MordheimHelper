namespace RuleServices.Models;

public class BandModel
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public UnitModel[] Units { get; set; }
}