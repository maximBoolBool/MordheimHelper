using RuleServices.Models;
using RuleServices.Models.Dto;

namespace RuleServices.Services;

public interface IArmorService
{
    Task<ArmorModel> GetAsync(long id, CancellationToken cancellationToken);

    Task<ArmorModel[]> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken);
}