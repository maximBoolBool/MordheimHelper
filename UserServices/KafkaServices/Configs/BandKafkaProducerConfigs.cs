using KafkaServices.Configs;

namespace UesrServices.KafkaServices.Configs;

public class BandKafkaProducerConfigs : IBaseKafkaProducerConfigs
{
    public string BootstrapServers { get; set; }
    public string Topic { get; set; }
}