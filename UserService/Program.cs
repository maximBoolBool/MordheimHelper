using System.Text;
using UesrServices;
using UserEntities;
using UserService.Models;
using UserService.Services;
using UserService.Services.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

var configs = builder.Configuration;

var jwtConfigs = new JwtConfigs
{
    Key = configs["Jwt:TokenKey"],
    Issuer = configs["Jwt:Issuer"],
    Audience = configs["Jwt:Audience"]
};

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddCookie()
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateIssuer = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtConfigs.Issuer,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfigs.Key))
        };
    });

var connectionString =  builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<UserDbContext>
    (opt => opt.UseNpgsql(connectionString));

builder.Services.AddSingleton(jwtConfigs);
builder.Services.AddSingleton<IJWTService, JwtService>();

builder.Services.AddUserRepositories();
builder.Services.AddUserServices(configs);
builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();