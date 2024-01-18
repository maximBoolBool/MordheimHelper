using Microsoft.AspNetCore.Mvc;
using RuleServices.Services;

namespace RuleService.Controllers;

/// <summary>
///     Контроллер для банд
/// </summary>
[Route("api/band")]
public class BandController : Controller
{
    #region Fields

    private IBandService _bandService;

    #endregion
    
    #region .ctor

    public BandController(IBandService bandService)
    {
        _bandService = bandService;
    }

    #endregion

    #region Get api/band

    /// <summary>
    ///     Получить лист банд
    /// </summary>
    public async Task<IActionResult> List(CancellationToken cancellationToken)
    {
        var response = await _bandService.ListAsync(cancellationToken);
        return Ok(response);
    }
    
    #endregion

    #region Get api/band/{id}

    /// <summary>
    ///     Получить банду по Id
    /// </summary>
    public async Task<IActionResult> GetBand([FromQuery] long id, CancellationToken cancellationToken)
    {
        var response = await _bandService.GetAsync(id, cancellationToken);
        return Ok(response);
    }

    #endregion
}