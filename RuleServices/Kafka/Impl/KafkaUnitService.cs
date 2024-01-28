using KafkaServices.Impl;
using SharedEntities.Models.DTO.Request;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Kafka.Impl;

public class KafkaUnitService : BaseKafkaService<UnitResponse, UnitRequest> , IKafkaUnitService
{
    public KafkaUnitService(
        IKafkaUnitConsumer consumer,
        IKafkaUnitProducer producer) 
        : base(consumer, producer) { }
}  