using KafkaServices.Impl;
using UesrServices.KafkaServices.Configs;
using UesrServices.Models.Request;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUserProducer : BaseKafkaProducer<UserRequestDto>, IKafkaUserProducer
{
    public KafkaUserProducer(KafkaUserProducerConfigs config) : base(config) { }
}