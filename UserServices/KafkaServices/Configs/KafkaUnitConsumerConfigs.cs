using KafkaServices.Configs;

namespace UesrServices.KafkaServices.Configs;

public class KafkaUnitConsumerConfigs : IBaseKafkaConsumerConfigs
{
    public string BootstrapServers { get; set; }
    public string GroupId { get; set; }
    public string Topic { get; set; }
}