using RuleServices.Models;

namespace RuleServices.Services;

public interface IBandService
{
    public Task<BandModel[]> List();
}