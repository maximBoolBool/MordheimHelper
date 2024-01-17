namespace KafkaServices.Impl;

public abstract class BaseKafkaService<TRequest, TResponse> : IKafkaService<TRequest, TResponse>
{
    /// <inheritdoc />
    public IKafkaConsumer<TResponse> Consumer { get; set; }

    /// <inheritdoc />
    public IKafkaProducer<TRequest> Producer { get; set; }
    
    /// <summary>
    ///     .ctor
    /// </summary>
    protected BaseKafkaService(IKafkaConsumer<TResponse> consumer, IKafkaProducer<TRequest> producer)
    {
        Consumer = consumer;
        Producer = producer;
    }
}