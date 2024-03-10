using KafkaServices;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Kafka;

public interface IKafkaUnitProducer : IKafkaProducer<UnitDto> { }