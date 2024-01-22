using KafkaServices;
using KafkaServices.Impl;
using UesrServices.Models.Request;
using UesrServices.Models.Response;

namespace UesrServices.KafkaServices.Impl;

public class KafkaUserService : BaseKafkaService<UserRequestDto, UserResponseDto>, IKafkaUserService
{
    public KafkaUserService(
        IKafkaConsumer<UserResponseDto> consumer,
        IKafkaProducer<UserRequestDto> producer) : base(consumer, producer) { }
}