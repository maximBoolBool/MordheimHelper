using KafkaServices;
using SharedEntities.Models.DTO.Request;

namespace UesrServices.KafkaServices;

public interface IKafkaUnitProducer : IKafkaProducer<UnitRequest> {}