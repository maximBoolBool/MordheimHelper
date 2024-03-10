using KafkaServices.Impl;
using SharedEntities.Models.DTO;
using UesrServices.KafkaServices.Configs;

namespace UesrServices.KafkaServices.Impl;

public class KafkaBandProducer : BaseKafkaProducer<BandRequestDTO>, IKafkaBandProducer
{
    public KafkaBandProducer(BandKafkaProducerConfigs configs) : base(configs) { }
}