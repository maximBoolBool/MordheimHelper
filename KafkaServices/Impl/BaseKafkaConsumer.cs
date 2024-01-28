using Confluent.Kafka;
using KafkaServices.Configs;
using KafkaServices.Helpers;

namespace KafkaServices.Impl;

public class BaseKafkaConsumer<TResponse> : IKafkaConsumer<TResponse> where TResponse : class 
{
    private readonly ConsumerConfig _config;
    private readonly string _topicName;

    public BaseKafkaConsumer(IBaseKafkaConsumerConfigs config)
    {
        _config = new ConsumerConfig()
        {
            BootstrapServers = config.BootstrapServers,
            GroupId = config.GroupId,
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = true, // Включение автоматической фиксации
        };

        _topicName = config.Topic;
    } 

    public async Task<TResponse> Consume(CancellationToken cancellationToken)
    {
        using var consumer = new ConsumerBuilder<Null, TResponse>(_config)
            .SetKeyDeserializer(Deserializers.Null)
            .SetValueDeserializer(new BaseClassDeserialization<TResponse>())
            .Build();
        
        consumer.Subscribe(_topicName);

        try
        {
            var consumeResult = consumer.Consume();
            consumer.Commit(consumeResult); // Явная фиксация
            return consumeResult.Message.Value;
        }
        catch (ConsumeException ex)
        {
            Console.WriteLine($"Error consuming message from Kafka: {ex.Error.Reason}");
            throw;
        }
        finally
        {
            consumer.Close();
        }
    }

}