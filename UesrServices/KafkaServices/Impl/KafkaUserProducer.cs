using KafkaServices.Configs;
using KafkaServices.Impl;
using SharedEntities.Models.DTO.Request;
using UesrServices.KafkaServices.Configs;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUserProducer : BaseKafkaProducer<UserRequestDto>, IKafkaUserProducer
{
    public KafkaUserProducer(KafkaUserProducerConfigs configs) : base(configs) { }
}