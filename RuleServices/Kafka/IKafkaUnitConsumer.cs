using KafkaServices;
using SharedEntities.Models.DTO.Request;

namespace RuleServices.Kafka;

public interface IKafkaUnitConsumer : IKafkaConsumer<UnitRequest> { }