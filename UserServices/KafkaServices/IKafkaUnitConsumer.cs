using KafkaServices;
using SharedEntities.Models.DTO.Response;

namespace UesrServices.KafkaServices;

public interface IKafkaUnitConsumer : IKafkaConsumer<UnitDto> { }