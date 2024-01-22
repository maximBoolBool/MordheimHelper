using KafkaServices;
using UesrServices.Models.Response;

namespace UesrServices.KafkaServices;

public interface IKafkaUserConsumer : IKafkaConsumer<UserResponseDto>  { }