using KafkaServices.Configs;

namespace RuleServices.Kafka.Configs;

/// <inheritdoc cref="IBaseKafkaConsumerConfigs"/>
public class KafkaBandConsumerConfigs : IBaseKafkaConsumerConfigs
{
    /// <inheritdoc/>
    public string BootstrapServers { get; set; }

    /// <inheritdoc/>
    public string GroupId { get; set; }
    
    /// <inheritdoc/>
    public string Topic { get; set; }
}