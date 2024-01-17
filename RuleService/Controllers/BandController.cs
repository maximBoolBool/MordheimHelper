using Microsoft.AspNetCore.Mvc;

namespace RuleService.Controllers;

/// <summary>
///     Контроллер для банд
/// </summary>
[Route("api/band")]
public class BandController : Controller
{
    #region Fields

    

    #endregion
    
    #region .ctor

    public BandController() { }

    #endregion

    #region Get api/band

    /// <summary>
    ///     Получить лист банд
    /// </summary>
    public async Task<IActionResult> List()
    {
        return Ok();
    }
    
    #endregion

    #region Get api/band/{id}

    /// <summary>
    ///     Получить банду по Id
    /// </summary>
    public async Task<IActionResult> GetBand([FromQuery] long id)
    {
        return Ok();
    }

    #endregion
}