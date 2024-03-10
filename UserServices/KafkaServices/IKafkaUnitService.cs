using KafkaServices;
using SharedEntities.Models.DTO.Request;
using SharedEntities.Models.DTO.Response;

namespace UesrServices.KafkaServices;

public interface IKafkaUnitService : IKafkaService<UnitRequest, UnitDto> { }