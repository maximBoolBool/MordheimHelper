using KafkaServices;
using KafkaServices.Impl;
using SharedEntities.Models.DTO;
using SharedEntities.Models.DTO.Response;

namespace UesrServices.KafkaServices.Impl;

public class KafkaBandService : BaseKafkaService<BandRequestDTO, BandDto>, IKafkaBandService
{
    public KafkaBandService(
        IKafkaBandConsumer consumer,
        IKafkaBandProducer producer)
        : base(consumer, producer)
    { }
}