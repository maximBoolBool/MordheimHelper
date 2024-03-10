using KafkaServices.Configs;
using KafkaServices.Impl;
using SharedEntities.Models.DTO.Request;
using UesrServices.KafkaServices.Configs;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUserProducer : BaseKafkaProducer<UserQueryDto>, IKafkaUserProducer
{
    public KafkaUserProducer(KafkaUserProducerConfigs configs) : base(configs) { }
}