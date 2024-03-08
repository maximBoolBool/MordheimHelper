using Microsoft.AspNetCore.Mvc;
using SharedEntities.Models.DTO.Request;
using UesrServices.Services;
using UserService.Services;

namespace UserService.Controllers;

/// <summary>
///     Контроллер для работы с пользователями
/// </summary>
[Route("api/users")]
public class UserController : Controller
{
    #region Fields

    private readonly IUserService _userService;
    private readonly IJWTService _jwtService;
        
    #endregion
    
    #region .ctor

    public UserController(IUserService userService, IJWTService jwtService)
    {
        _userService = userService;
        _jwtService = jwtService;
    }

    #endregion

    #region POST api/user/sign-up

    [HttpPost("/sign-up")]
    public async Task<IActionResult> SignUp([FromRoute] UserQueryDto query, CancellationToken cancellationToken)
    {
        await _userService.RegistrateUserAsync(query, cancellationToken);
        _jwtService.AddRefreshToken(HttpContext);
        _jwtService.AddAccessToken(HttpContext);
        return Ok();
    }

    #endregion
    
    #region GET api/user/login

    [HttpGet("login")]
    public async Task<IActionResult> Login([FromBody] UserQueryDto query, CancellationToken cancellationToken)
    {
        await _userService.AuthenticateAsync(query, cancellationToken);
        _jwtService.AddRefreshToken(HttpContext);
        _jwtService.AddAccessToken(HttpContext);
        return Ok();
    }

    #endregion

    #region DELETE api/user/delete

    [HttpDelete("delete/{id:long}")]
    public async Task<IActionResult> Delete([FromQuery] long id,CancellationToken cancellationToken)
    {
        return Ok();
    }

    #endregion

    #region PUT api/user/logoff/{id}

    [HttpPut("logoff")]
    public async Task<IActionResult> Logoff([FromRoute] long id, CancellationToken cancellationToken)
    {
        await _userService.LogoffAsync(id, cancellationToken);
        return Ok();
    }
    
    #endregion

    #region Post api/user/refresh

    [HttpPost("/refresh")]
    public async Task<IActionResult> Refresh()
    {
        await _userService.RefreshAsync();
        return Ok();
    }

    #endregion
}