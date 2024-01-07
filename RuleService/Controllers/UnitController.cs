using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using RuleEntities.Entities;
using RuleEntities.Repositories;

namespace RuleService.Controllers;

/// <summary>
///     Контроллер для юнитов-ов
/// </summary>
[Route("api/unit")]
public class UnitController : Controller
{
    private readonly IUnitRepository _unitRepository;
    
    /// <summary>
    ///     .ctor
    /// </summary>
    public UnitController(IUnitRepository unitRepository)
    {
        _unitRepository = unitRepository;
    }

    #region GET ~api/untit

    /// <summary>
    ///     Получить отряд по Id
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [
        HttpGet,
        Route("set")
    ]
    public async Task<IActionResult> GetUnit([FromQuery] string id, CancellationToken cancellationToken)
    {
        return Ok();
    }


    #endregion
}