using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UesrServices.Impl;
using UesrServices.KafkaServices;
using UesrServices.KafkaServices.Configs;
using UesrServices.KafkaServices.Impl;

namespace UesrServices;

public static class ServiiceCollectionExtension
{
    public static void AddUserServices(this IServiceCollection services, IConfiguration configs)
    {
        services.AddSingleton(new KafkaUserProducerConfigs
        {
            BootstrapServers = "localhost:9092",
            Topic = "test-topic",
        });
        services.AddSingleton(new KafkaUserConsumerConfigs
        {
            BootstrapServers = "localhost:9092",
            Topic = "test-topic",
            GroupId = "id"
        });

        services.AddSingleton(new KafkaUnitConsumerConfigs()
        {
            BootstrapServers = "localhost:9092",
            Topic = "unit-response-topic",
            GroupId = "group-id"
        });

        services.AddSingleton(new KafkaUnitProducerConfigs()
        {
            BootstrapServers = "localhost:9092",
            Topic = "unit-request-topic"
        });
        
        services.AddAutoMapper(typeof(UserServiceMapperProfile));

        services.AddScoped<IKafkaUnitConsumer, KafkaUnitConsumers>();
        services.AddScoped<IKafkaUnitProducer, KafkaUnitProducer>();
        services.AddScoped<IKafkaUnitService, KafkaUnitService>();
        
        services.AddScoped<IKafkaUserConsumer, KafkaUserConsumer>();
        services.AddScoped<IKafkaUserProducer, KafkaUserProducer>();
        services.AddScoped<IKafkaUserService, KafkaUserService>();

        services.AddScoped<IUserService, UserService>();
    }
}