using RuleServices.Models;
using RuleServices.Models.Dto;

namespace RuleServices.Services;

public interface IBandService
{
    public Task<BandModel[]> ListAsync(BandListQuery query ,CancellationToken cancellationToken);

    public Task<BandModel> GetAsync(long id, CancellationToken cancellationToken);
}