using KafkaServices.Configs;

namespace RuleServices.Kafka.Configs;

public class KafkaUnitProducerConfigs : IBaseKafkaProducerConfigs
{
    public string BootstrapServers { get; set; }
    public string Topic { get; set; }
}