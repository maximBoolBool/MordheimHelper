using System.Net;
using Microsoft.AspNetCore.Mvc;
using RuleServices.Enums;
using RuleServices.Models.Dto;
using RuleServices.Services;
using SharedEntities.Models;
using SharedEntities.Models.DTO.Response;

namespace RuleService.Controllers;

[Route("api/eqipment")]
[ApiController]
public class EqipmentController : Controller
{
    #region Fields

    private readonly IArmorService _armor;

    private readonly ICloseCombatWeaponService _closeCombatWeapons;

    private readonly IRangeWeaponService _rangeWeapons;
    
    #endregion

    #region .ctor

    public EqipmentController(
        IRangeWeaponService rangeWeapons,
        ICloseCombatWeaponService closeCombatWeapons,
        IArmorService armor)
    {
        _rangeWeapons = rangeWeapons;
        _closeCombatWeapons = closeCombatWeapons;
        _armor = armor;
    }

    #endregion

    #region GET api/eqipment/id

    public async Task<IActionResult> Get([FromQuery] EqiepmentQuery query, CancellationToken cancellationToken)
    {
        IEquipmentResponse response = null;
        switch (query.Type)
        {
            case EqipmentType.Armour:
                response = await _armor.GetAsync(query.Id, cancellationToken);
                break;
            case EqipmentType.RangeWeapon:
                response = await _rangeWeapons.GetAsync(query.Id, cancellationToken);
                break;
            case EqipmentType.CloseCombatWeapon:
                response = await _closeCombatWeapons.GetAsync(query.Id, cancellationToken);
                break;
            default:
                throw new ErrorException(HttpStatusCode.NotFound, "Eqipment type not found");
        }
        return Ok(response);
    }

    #endregion

    #region GET api/eqipment

    public async Task<IActionResult> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken)
    {
        var contracts = new List<IEquipmentResponse>();
        foreach (var type in query.Types)
        {
            switch (type)
            {  
                case EqipmentType.Armour:
                    var armors = await _armor.ListAsync(query, cancellationToken);
                    contracts.AddRange(armors);
                    break;
                case EqipmentType.RangeWeapon:
                    var rangeWeapons = await _rangeWeapons.ListAsync(query, cancellationToken);
                    contracts.AddRange(rangeWeapons);
                    break;
                case EqipmentType.CloseCombatWeapon:
                    var closeWeapons = await _closeCombatWeapons.ListAsync(query, cancellationToken);
                    contracts.AddRange(closeWeapons);
                    break;
            }
        }
        return Ok(contracts);
    }

    #endregion
}