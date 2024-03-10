using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UesrServices.Models.Queries;
using UesrServices.Models.Requests;

namespace UserService.Controllers;

[ApiController]
[Route("band")]
public class BandController : Controller
{
    #region Fields

    

    #endregion

    #region POST api/band

    /// <summary>
    ///     Создать новую банду
    /// </summary>
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(
        long userId,
        [FromBody] CreateBandRequest request,
        CancellationToken cancellationToken)
    {
        return Ok();
    }

    #endregion

    #region DELETE api/band/{id}
    
    /// <summary>
    ///     Удалить банду
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> Delete(
        [FromQuery] long bandId,
        CancellationToken cancellationToken)
    {
        return Ok();
    }

    #endregion

    /// <summary>
    ///     Получить созданные банды
    /// </summary>
    [HttpGet("list")]
    [Authorize]
    public async Task<IActionResult> List(
        [FromQuery] ListBandQuery query,
        CancellationToken cancellationToken)
    {
        return Ok();
    }

    /// <summary>
    ///     Получить банду по id
    /// </summary>
    public async Task<IActionResult> Get([FromQuery] long id)
    {
        return Ok();
    }

}