using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using UserService.Models;

namespace UserService.Services.Impl;
//TODO добавить в конфигурацию

/// <inheritdoc cref="IJWTService"/>
public class JwtService : IJWTService
{
    #region Fields

    private readonly JwtConfigs _configs;
    
    #endregion

    #region .ctor

    public JwtService(JwtConfigs configs)
    {
        _configs = configs;
    }

    #endregion
    

    public void AddRefreshToken(HttpContext context)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configs.Key));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.Sha256);
        var refreshToken = new JwtSecurityToken(
            _configs.Issuer,
            _configs.Audience,
            signingCredentials: credentials,
            expires: DateTime.UtcNow.AddDays(15)
        );

        var cookieOptions = new CookieOptions
        {
            Expires = DateTime.UtcNow.AddDays(15),
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Strict
        };
        
        var tokenHandler = new JwtSecurityTokenHandler();
        context.Response.Cookies
            .Append("refresh_token", tokenHandler.WriteToken(refreshToken), cookieOptions);
    }

    public void AddAccessToken(HttpContext context)
    {
        var accesClaims = new[]
        {
            new Claim(ClaimTypes.Role, "")
        };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configs.Key));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.Sha256);
        var acsessToken = new JwtSecurityToken(
            _configs.Issuer,
            _configs.Audience,
            accesClaims,
            signingCredentials: credentials,
            expires: DateTime.UtcNow.AddMinutes(15)
        );
        
        var cookieOptions = new CookieOptions
        {
            Expires = DateTime.UtcNow.AddMinutes(15),
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Strict
        };
        
        var tokenHandler = new JwtSecurityTokenHandler();
        context.Response.Cookies
            .Append("access_token", tokenHandler.WriteToken(acsessToken), cookieOptions);
    }
}