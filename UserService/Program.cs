using Microsoft.EntityFrameworkCore;
using UserEntities;

var builder = WebApplication.CreateBuilder(args);

var connectionString =  builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<UserDbContext>
    (opt => opt.UseNpgsql(connectionString));
builder.Services.AddUserRepositories();
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.Run();