using MongoDB.Driver;
using RuleEntities;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MongoDbConnection");

builder.Services
    .AddScoped<IMongoClient>(provider => new MongoClient(connectionString));

builder.Services
    .AddScoped<IMongoDatabase>(provider =>
    {
        var client = provider.GetRequiredService<IMongoClient>();
        return client.GetDatabase("rulses_db");
    });
builder.Services.AddRepositories();
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();