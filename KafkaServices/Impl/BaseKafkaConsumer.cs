using Confluent.Kafka;
using KafkaServices.Configs;
using Microsoft.Extensions.Logging;

namespace KafkaServices.Impl;

/// <summary>
///     Базовый потребитель сообщений из Kafka 
/// </summary>
public class BaseKafkaConsumer<TResponse> : IKafkaConsumer<TResponse>
{
    private readonly ConsumerConfig _config;

    private readonly ILogger _log;
    
    public BaseKafkaConsumer(IBaseKafkaConsumerConfigs config, ILogger log)
    {
        _config = new ConsumerConfig()
        {
            BootstrapServers =  config.BootstrapServers,
            GroupId = config.GroupId,
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = false,
        };

        _log = log;
    } 

    public async Task<TResponse> ConsumeAsync(CancellationToken cancellationToken)
    {
        using var consumer = new ConsumerBuilder<Ignore, TResponse>(_config).Build();
        var response = await Task.Run(() => consumer.Consume(cancellationToken), cancellationToken);
        return response.Message.Value;
    }
}