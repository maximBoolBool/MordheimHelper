using KafkaServices;
using SharedEntities.Models.DTO.Request;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Kafka;

public interface IKafkaUnitService : IKafkaService<UnitDto, UnitRequest>{ }