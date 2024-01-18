using RuleServices.Models;

namespace RuleServices.Services;

public interface IBandService
{
    public Task<BandModel[]> ListAsync(CancellationToken cancellationToken);

    public Task<BandModel> GetAsync(long id, CancellationToken cancellationToken);
}