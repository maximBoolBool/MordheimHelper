using RuleServices.Models;
using RuleServices.Models.Dto;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Services;

public interface IArmorService
{
    Task<ArmorDto> GetAsync(long id, CancellationToken cancellationToken);

    Task<ArmorDto[]> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken);
}