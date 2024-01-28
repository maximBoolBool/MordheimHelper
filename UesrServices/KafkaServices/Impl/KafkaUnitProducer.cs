using KafkaServices.Impl;
using SharedEntities.Models.DTO.Request;
using UesrServices.KafkaServices.Configs;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUnitProducer : BaseKafkaProducer<UnitRequest>, IKafkaUnitProducer 
{
    public KafkaUnitProducer(KafkaUnitProducerConfigs configs) : base(configs) { }
}