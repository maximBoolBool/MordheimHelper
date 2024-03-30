using KafkaServices.Impl;
using RuleServices.Kafka.Configs;
using SharedEntities.Models.DTO;

namespace RuleServices.Kafka.Impl;

public class KafkaBandConsumer : BaseKafkaConsumer<BandRequestDto> , IBandKafkaConsumer
{
    public KafkaBandConsumer(KafkaBandConsumerConfigs config) : base(config) { }
}