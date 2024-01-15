using RuleEntities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRepositories();
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();