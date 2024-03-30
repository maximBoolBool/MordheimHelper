using KafkaServices;
using SharedEntities.Models.DTO;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Kafka;

/// <inheritdoc cref="IKafkaService{BandDto, BandRequestDTO}"/>
public interface IBandKafkaService : IKafkaService<BandDto, BandRequestDto> { }