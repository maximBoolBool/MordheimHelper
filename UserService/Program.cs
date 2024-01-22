using Microsoft.EntityFrameworkCore;
using UesrServices;
using UserEntities;

var builder = WebApplication.CreateBuilder(args);

var connectionString =  builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<UserDbContext>
    (opt => opt.UseNpgsql(connectionString));

var configs = builder.Configuration;

builder.Services.AddUserServices(configs);
builder.Services.AddUserRepositories();
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.Run();