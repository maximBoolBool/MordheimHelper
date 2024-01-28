using KafkaServices;
using KafkaServices.Impl;
using SharedEntities.Models.DTO.Request;
using SharedEntities.Models.DTO.Response;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUnitService : BaseKafkaService<UnitRequest, UnitResponse> , IKafkaUnitService
{
    public KafkaUnitService(
        IKafkaUnitConsumer consumer,
        IKafkaUnitProducer producer) : base(consumer, producer) { }
} 