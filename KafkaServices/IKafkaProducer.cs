namespace KafkaServices;

/// <summary>
///     Создатель сообщений для Kafka
/// </summary>
public interface IKafkaProducer<TRequest>
{
    /// <summary>
    ///     Создать сообщение в Kafka 
    /// </summary>
    public Task ProduceAsync(TRequest request, CancellationToken cancellationToken);
}