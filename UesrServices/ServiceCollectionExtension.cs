using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UesrServices.Impl;
using UesrServices.KafkaServices;
using UesrServices.KafkaServices.Impl;
namespace UesrServices;

public static class ServiiceCollectionExtension
{
    public static void AddUserServices(this IServiceCollection services, IConfiguration configs)
    {
        services.AddScoped<IKafkaUserConsumer, KafkaUserConsumer>();
        services.AddScoped<IKafkaUserProducer, KafkaUserProducer>();
        services.AddScoped<IKafkaUserService, KafkaUserService>();
        services.AddScoped<IUserService, UserService>();
    }
}