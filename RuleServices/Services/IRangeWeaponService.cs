using RuleServices.Models;
using RuleServices.Models.Dto;

namespace RuleServices.Services;

public interface IRangeWeaponService
{
    Task<RangeWeaponModel> GetAsync(long id, CancellationToken cancellationToken);

    Task<RangeWeaponModel[]> ListAsync(EquepmentListQuery id, CancellationToken cancellationToken);
}