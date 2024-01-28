using Microsoft.AspNetCore.Mvc;
using SharedEntities.Models.DTO.Request;
using UesrServices;
using UesrServices.KafkaServices;

namespace UserService.Controllers;

/// <summary>
///     Контроллер для работы с пользователями
/// </summary>
[Route("api/users")]
public class UserController : Controller
{
    #region Fields

    private readonly IUserService _userService;

    private readonly IKafkaUserService _kafkaService;
    
    #endregion
    
    #region .ctor

    public UserController(IUserService userService, IKafkaUserService kafkaService)
    {
        _userService = userService;
        _kafkaService = kafkaService;
    }

    #endregion

    #region POST api/user/login

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UserRequestDto request, CancellationToken cancellationToken)
    {
        await _userService.RegistrateUserAsync(request, cancellationToken);
        return Ok();
    }

    #endregion

    #region DELETE api/user/delete

    [HttpDelete("delete/{id:long}")]
    public async Task<IActionResult> Delete([FromQuery] long id,CancellationToken cancellationToken)
    {
        await _kafkaService.Producer.ProduceAsync(new UserRequestDto(), cancellationToken);
        var response = _kafkaService.Consumer.Consume(cancellationToken);
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