using KafkaServices;
using KafkaServices.Impl;
using SharedEntities.Models.DTO;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Kafka.Impl;

public class BandKafkaService : BaseKafkaService<BandDto, BandRequestDto>, IBandKafkaService
{
    public BandKafkaService(
        KafkaBandConsumer consumer,
        KafkaBandProducer producer) 
        : base(consumer, producer) { }
}