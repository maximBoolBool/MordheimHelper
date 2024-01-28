namespace KafkaServices;

public interface IKafkaBackGroundConsumer<TRequest> : IDisposable 
{
    public TRequest Consume();
}