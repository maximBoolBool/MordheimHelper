using KafkaServices.Configs;
using KafkaServices.Impl;
using SharedEntities.Models.DTO.Response;
using UesrServices.KafkaServices.Configs;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUserConsumer : BaseKafkaConsumer<UserResponseDto>, IKafkaUserConsumer
{
    public KafkaUserConsumer(KafkaUserConsumerConfigs config) : base(config) { }
}