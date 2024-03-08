using Microsoft.AspNetCore.Mvc;
using RuleEntities.Repositories;
using RuleServices.Models.Dto;
using RuleServices.Services;

namespace RuleService.Controllers;

/// <summary>
///     Контроллер для юнитов-ов
/// </summary>
[ApiController]
[Route("api/units")]
public class UnitController : Controller
{
    #region Fields

    private readonly IUnitService _unitService;
    
    #endregion

    #region .ctor

    /// <summary>
    ///     .ctor
    /// </summary>
    public UnitController(IUnitService unitService)
    {
        _unitService = unitService;
    }

    #endregion
    
    #region GET units/id

    [HttpGet("{id}:long")]
    public async Task<IActionResult> Get([FromQuery] long id, CancellationToken cancellationToken)
    {
        var contract = await _unitService.GetAsync(id, cancellationToken);
        return Ok(contract);
    }
    
    #endregion

    #region GET units

    public async Task<IActionResult> List([FromQuery] UnitQuery query, CancellationToken cancellationToken)
    {
        var contracts = await _unitService.ListAsync(query, cancellationToken);
        return Ok(contracts);
    }

    #endregion
}