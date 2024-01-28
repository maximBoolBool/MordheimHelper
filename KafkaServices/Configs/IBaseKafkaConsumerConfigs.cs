namespace KafkaServices.Configs;

/// <summary>
///     Интерфейс
/// </summary>
public interface IBaseKafkaConsumerConfigs
{
    /// <summary>
    ///     Строка подключения к кафке
    /// </summary>
    public string BootstrapServers { get; set; }
    
    /// <summary>
    ///     Id группы потребителей
    /// </summary>
    public string GroupId { get; set; }
    
    /// <summary>
    ///     Название топика
    /// </summary>
    public string Topic { get; set; }
}