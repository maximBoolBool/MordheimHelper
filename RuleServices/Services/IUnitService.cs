using RuleServices.Models.Dto;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Services;

public interface IUnitService
{
    public Task<UnitDto[]> ListAsync(UnitQuery query, CancellationToken cancellationToken);

    public Task<UnitDto> GetAsync(long id, CancellationToken cancellationToken);
}