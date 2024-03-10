using KafkaServices.Impl;
using SharedEntities.Models.DTO.Request;
using SharedEntities.Models.DTO.Response;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUserService : BaseKafkaService<UserQueryDto, UserResponseDto> , IKafkaUserService
{
    public KafkaUserService(
        IKafkaUserConsumer consumer, 
        IKafkaUserProducer producer)
        : base(consumer, producer) { }
}