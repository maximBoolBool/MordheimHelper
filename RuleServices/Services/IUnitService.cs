using RuleServices.Models.Dto;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Services;

public interface IUnitService
{
    public Task<UnitResponse[]> ListAsync(UnitQuery query, CancellationToken cancellationToken);

    public Task<UnitResponse> GetAsync(long id, CancellationToken cancellationToken);
}