using KafkaServices.Configs;
using KafkaServices.Impl;
using RuleServices.Kafka.Configs;
using SharedEntities.Models.DTO.Request;

namespace RuleServices.Kafka.Impl;

internal class KafkaUnitConsumer : BaseKafkaConsumer<UnitRequest>, IKafkaUnitConsumer
{
    public KafkaUnitConsumer(KafkaUnitConsumerConfigs config) : base(config) { }
}