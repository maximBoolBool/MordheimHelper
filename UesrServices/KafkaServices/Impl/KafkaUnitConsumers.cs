using KafkaServices.Impl;
using SharedEntities.Models.DTO.Response;
using UesrServices.KafkaServices.Configs;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUnitConsumers : BaseKafkaConsumer<UnitResponse>, IKafkaUnitConsumer
{
    public KafkaUnitConsumers(KafkaUnitConsumerConfigs config) : base(config) { }
}