using KafkaServices;
using SharedEntities.Models.DTO;
using SharedEntities.Models.DTO.Response;
using UesrServices.Models;

namespace UesrServices.KafkaServices;

public interface IKafkaBandConsumer : IKafkaConsumer<BandDto> { }