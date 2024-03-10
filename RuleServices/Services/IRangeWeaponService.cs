using RuleServices.Models;
using RuleServices.Models.Dto;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Services;

public interface IRangeWeaponService
{
    Task<RangeWeaponDto> GetAsync(long id, CancellationToken cancellationToken);

    Task<RangeWeaponDto[]> ListAsync(EquepmentListQuery id, CancellationToken cancellationToken);
}