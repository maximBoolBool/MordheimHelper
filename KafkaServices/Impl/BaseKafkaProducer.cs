using Confluent.Kafka;
using KafkaServices.Configs;
using KafkaServices.Helpers;

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
        using var producer = new ProducerBuilder<Null, TRequest>(_configs)
            .SetKeySerializer(Serializers.Null)
            .SetValueSerializer(new BaseClassSerialization<TRequest>())
            .Build();

        var message = new Message<Null, TRequest>()
        {
            Value = request,
        };
        
        var result = await producer.ProduceAsync(_topic, message, cancellationToken);
        producer.Dispose();
    }
}