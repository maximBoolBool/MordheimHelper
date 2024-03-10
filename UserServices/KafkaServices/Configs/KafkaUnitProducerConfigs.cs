using KafkaServices.Configs;

namespace UesrServices.KafkaServices.Configs;

public class KafkaUnitProducerConfigs : IBaseKafkaProducerConfigs
{
    public string BootstrapServers { get; set; }
    public string Topic { get; set; }
}