namespace KafkaServices;

/// <summary>
///     Потребитель данных из Kafka
/// </summary>
public interface IKafkaConsumer<TResponse>
{
    public Task<TResponse> ConsumeAsync(CancellationToken cancellationToken);
}