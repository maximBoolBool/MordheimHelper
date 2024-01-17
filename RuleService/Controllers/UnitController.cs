using Microsoft.AspNetCore.Mvc;
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

}