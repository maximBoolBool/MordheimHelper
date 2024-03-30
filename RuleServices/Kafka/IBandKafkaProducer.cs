using KafkaServices;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Kafka;

/// <inheritdoc cref="IKafkaProducer{BandDto}"/>
public interface IBandKafkaProducer : IKafkaProducer<BandDto> { }