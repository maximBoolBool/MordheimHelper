using Microsoft.EntityFrameworkCore;
using RuleEntities;
using RuleServices;

var builder = WebApplication.CreateBuilder(args);

var conection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<RuleDbContext>(opt => opt.UseNpgsql(conection));

builder.Services.AddRuleRepositories();
builder.Services.AddRuleService();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

await app.RunAsync();