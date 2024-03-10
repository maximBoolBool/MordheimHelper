namespace KafkaServices;

/// <summary>
///     Интерфейс для кафки
/// </summary>
public interface IKafkaService<TRequest, TResponse>
{
    /// <summary>
    ///     Потребитель сообщений
    /// </summary>
    public IKafkaConsumer<TResponse> Consumer {get; set; }
    
    /// <summary>
    ///     Создатель сообщений
    /// </summary>
    public IKafkaProducer<TRequest> Producer { get; set; }

    /// <summary>
    ///     Получить
    /// </summary>
    public Task<TResponse> GetAsync(TRequest reqest, CancellationToken cancellationToken = default);
}