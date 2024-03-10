using RuleServices.Models;
using RuleServices.Models.Dto;
using RuleServices.Models.Dto.Response;

namespace RuleServices.Services;

public interface IBandService
{
    public Task<BandModel[]> ListAsync(BandListQuery query ,CancellationToken cancellationToken);

    public Task<BandModel> GetAsync(long id, CancellationToken cancellationToken);
}