using RuleServices.Models;
using RuleServices.Models.Dto;

namespace RuleServices.Services;


public interface ICloseCombatWeaponService
{
    Task<CloseWeaponModel> GetAsync(long id, CancellationToken cancellationToken);

    Task<CloseWeaponModel[]> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken);
}