using KafkaServices.Configs;

namespace RuleServices.Kafka.Configs;

/// <inheritdoc cref="IBaseKafkaProducerConfigs"/>
public class KafkaBandProducerConfigs : IBaseKafkaProducerConfigs
{
    /// <inheritdoc/>
    public string BootstrapServers { get; set; }

    /// <inheritdoc/>
    public string Topic { get; set; }
}