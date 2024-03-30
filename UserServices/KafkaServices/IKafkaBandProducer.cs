using KafkaServices;
using SharedEntities.Models.DTO;

namespace UesrServices.KafkaServices;

public interface IKafkaBandProducer : IKafkaProducer<BandRequestDto> { }