using KafkaServices.Configs;

namespace RuleServices.Kafka.Configs;

public class KafkaUnitConsumerConfigs : IBaseKafkaConsumerConfigs
{
    public string BootstrapServers { get; set; }
    public string GroupId { get; set; }
    
    public string Topic { get; set; }
}