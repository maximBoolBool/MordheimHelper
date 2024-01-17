namespace SharedEntities.Configs;

/// <summary>
///     Создатель сообщений для Kafka
/// </summary>
public interface IBaseKafkaProducerConfigs
{
    /// <summary>
    ///     Строка подкллючения
    /// </summary>
    public string BootstrapServers { get; set; }
    
    /// <summary>
    ///     Топик
    /// </summary>
    public string Topic { get; set; }
}