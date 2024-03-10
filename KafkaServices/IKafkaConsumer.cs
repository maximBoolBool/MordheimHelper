using Microsoft.Extensions.Hosting;

namespace KafkaServices;

/// <summary>
///     Потребитель данных из Kafka
/// </summary>
public interface IKafkaConsumer<TResponse>
{
    public Task<TResponse> Consume(CancellationToken cancellationToken = default);
}