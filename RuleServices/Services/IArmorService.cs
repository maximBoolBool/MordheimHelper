using RuleServices.Models;
using RuleServices.Models.Dto;

namespace RuleServices.Services;

public interface IArmorService
{
    Task<ArmorDto> GetAsync(long id, CancellationToken cancellationToken);

    Task<ArmorDto[]> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken);
}