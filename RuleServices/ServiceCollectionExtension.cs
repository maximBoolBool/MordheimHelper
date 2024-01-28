using Microsoft.Extensions.DependencyInjection;
using RuleServices.BackGround;
using RuleServices.Kafka;
using RuleServices.Kafka.Configs;
using RuleServices.Kafka.Impl;
using RuleServices.Mappers;
using RuleServices.Services;
using RuleServices.Services.Impl;

namespace RuleServices;

public static class ServiceCollectionExtension
{
    public static void AddRuleService(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(RuleMapperProfile));

        services.AddSingleton(new KafkaUnitConsumerConfigs
        {
            BootstrapServers = "localhost:9092",
            GroupId = "group-id",
            Topic = "unit-request-topic"
        });

        services.AddSingleton(new KafkaUnitProducerConfigs
        {
            BootstrapServers = "localhost:9092",
            Topic = "unit-response-topic"
        });
        
        services.AddScoped<IKafkaUnitConsumer, KafkaUnitConsumer>();
        services.AddScoped<IKafkaUnitProducer, KafkaUnitProducer>();
        services.AddScoped<IKafkaUnitService, KafkaUnitService>();
        services.AddScoped<IBandService, BandService>();
        services.AddHostedService<UnitsBackgroundService>();
    }
}