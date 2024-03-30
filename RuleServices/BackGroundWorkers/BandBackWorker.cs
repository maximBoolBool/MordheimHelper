using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RuleEntities;
using RuleServices.Kafka;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.BackGroundWorkers;

public class BandBackWorker : IHostedService
{
    private bool _isWork = true;
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly IBandKafkaConsumer _bandConsumer;

    public BandBackWorker(
        IServiceScopeFactory scopeFactory,
        IBandKafkaConsumer bandConsumer)
    {
        _scopeFactory = scopeFactory;
        _bandConsumer = bandConsumer;
    }
    
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        while (_isWork)
        {
            var requst = await _bandConsumer.Consume(cancellationToken);
            var dbFactory = _scopeFactory.CreateScope().ServiceProvider.GetService<RuleDbWorkerFactory>();
            using var dbWorker = dbFactory.CreateScopeDatabase();

            var query = dbWorker.Bands.CreateQuery();

            var entity = await query.Include(b => b.Units)
                .ThenInclude(u => u.Armors)
                .Include(b => b.SpecialRules)
                .FirstOrDefaultAsync(e => e.Id == requst.Id, cancellationToken);

            
            var mapper = _scopeFactory.CreateScope().ServiceProvider.GetService<IMapper>();
            var response = mapper.Map<BandDto>(entity);
            var kafkaProducer = _scopeFactory.CreateScope().ServiceProvider.GetService<IBandKafkaProducer>();

            await kafkaProducer.ProduceAsync(response, cancellationToken);
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _isWork = false;
    }
}