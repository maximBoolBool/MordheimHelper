using Confluent.Kafka;
using KafkaServices.Configs;

namespace KafkaServices.Impl;

/// <summary>
///        Продюсер для сообщений Kafka
/// </summary>
public class BaseKafkaProducer<TRequest> : IKafkaProducer<TRequest>
{
    private readonly ProducerConfig _configs;

    private readonly string _topic;

    /// <inheritdoc cref="IKafkaProducer{TRequest}" />
    public BaseKafkaProducer(IBaseKafkaProducerConfigs configs)
    {
        _configs = new ProducerConfig()
        {
            BootstrapServers = configs.BootstrapServers
        };

        _topic = configs.Topic;
    }

    /// <inheritdoc cref="IKafkaProducer{TRequest}" />
    public async Task ProduceAsync(TRequest request, CancellationToken cancellationToken)
    {
        using var producer = new ProducerBuilder<Ignore, TRequest>(_configs).Build();

        var message = new Message<Ignore, TRequest>()
        {
            Value = request,
        };
        
        var result = await producer.ProduceAsync(_topic, message, cancellationToken);
    }
}