using KafkaServices.Impl;
using RuleServices.Kafka.Configs;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Kafka.Impl;

/// <inheritdoc cref="BaseKafkaProducer{TRequest}"/>
public class KafkaBandProducer : BaseKafkaProducer<BandDto>, IBandKafkaProducer
{
    /// <inheritdoc cref="BaseKafkaProducer{TRequest}"/>
    public KafkaBandProducer(KafkaBandProducerConfigs configs) : base(configs) { }
}