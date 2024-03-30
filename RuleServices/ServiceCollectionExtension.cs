using Microsoft.Extensions.DependencyInjection;
using RuleServices.BackGroundWorkers;
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
        services.AddScoped<IArmorService, ArmorService>();
        services.AddScoped<ICloseCombatWeaponService, CloseCombatWeaponService>();
        services.AddScoped<IRangeWeaponService, RangeWeaponService>();
        services.AddScoped<IUnitService, UnitService>();
        services.AddScoped<IBandService, BandService>();
        
        AddKafkaConfigs(services);
        services.AddScoped<IKafkaUnitConsumer, KafkaUnitConsumer>();
        services.AddScoped<IKafkaUnitProducer, KafkaUnitProducer>();
        services.AddScoped<IKafkaUnitService, KafkaUnitService>();
        AddBackGroudWorkers(services);
    }

    private static void AddKafkaConfigs(IServiceCollection services)
    {
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

        services.AddSingleton(new KafkaBandConsumerConfigs()
        {
            BootstrapServers = "localhost:9092",
            GroupId = "group-id",
            Topic = "band-request-topic"
        });

        services.AddSingleton(new KafkaBandProducerConfigs()
        {
            BootstrapServers = "localhost:9092",
            Topic = "unit-response-topic"
        });
    }

    private static void AddBackGroudWorkers(IServiceCollection services)
    {
        services.AddHostedService<BandBackWorker>();
    }
}