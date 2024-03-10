using SharedEntities.Models.DTO.Response;
using UesrServices.Models;
using UesrServices.Models.Queries;
using UesrServices.Models.Requests;

namespace UesrServices.Services;

public interface IBandManager
{
    public Task<BandResponse> CreateAsync(
        long userId,
        CreateBandRequest request,
        CancellationToken cancellationToken = default);

    public Task<BandResponse> UpdateAsync(
        long userId,
        UpdateBandRequest request,
        CancellationToken cancellationToken = default);

    public Task DeletAsync(long userId, long bandId);

    public Task<BandDto> GetAsync(long bandId, CancellationToken cancellationToken = default);

    public Task<BandDto[]> ListAsync(ListBandQuery query, CancellationToken cancellationToken);
}