using KafkaServices.Impl;
using Microsoft.Extensions.Logging;
using UesrServices.KafkaServices.Configs;
using UesrServices.Models.Response;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUserConsumer : BaseKafkaConsumer<UserResponseDto> , IKafkaUserConsumer
{
    public KafkaUserConsumer(KafkaUserConsumerConfigs config, ILogger log) : base(config, log) { }
}