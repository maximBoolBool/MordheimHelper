using KafkaServices.Configs;
using KafkaServices.Impl;
using RuleServices.Kafka.Configs;
using SharedEntities.Models.DTO.Request;

namespace RuleServices.Kafka.Impl;

public class KafkaUnitConsumer : BaseKafkaConsumer<UnitRequest>, IKafkaUnitConsumer
{
    public KafkaUnitConsumer(KafkaUnitConsumerConfigs config) : base(config) { }
}