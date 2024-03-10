using KafkaServices.Configs;

namespace UesrServices.KafkaServices.Configs;

public class KafkaUserProducerConfigs : IBaseKafkaProducerConfigs
{
    public string BootstrapServers { get; set; }
    
    public string Topic { get; set; }
}