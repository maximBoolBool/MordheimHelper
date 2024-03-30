using KafkaServices;
using SharedEntities.Models.DTO;

namespace RuleServices.Kafka;

/// <inheritdoc cref="IKafkaConsumer{BandRequestDto}"/>
public interface IBandKafkaConsumer : IKafkaConsumer<BandRequestDto> { }