using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RuleServices.Kafka;

namespace RuleServices.BackGround;

public class UnitsBackgroundService : IHostedService
{
    private readonly IServiceScopeFactory _scopeFactory;
    
    public UnitsBackgroundService(IServiceScopeFactory scopedFactory)
    {
        _scopeFactory = scopedFactory;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using var scoped = _scopeFactory.CreateScope();

        while (!cancellationToken.IsCancellationRequested)
        {
            var unitConsumer = scoped.ServiceProvider.GetRequiredService<IKafkaUnitConsumer>();
            var k =unitConsumer.Consume(cancellationToken);
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}