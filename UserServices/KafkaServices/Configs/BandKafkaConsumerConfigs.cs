using KafkaServices.Configs;

namespace UesrServices.KafkaServices.Configs;

public class BandKafkaConsumerConfigs : IBaseKafkaConsumerConfigs
{
    public string BootstrapServers { get; set; }
    
    public string GroupId { get; set; }
 
    public string Topic { get; set; }
}