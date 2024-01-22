using KafkaServices;
using UesrServices.Models.Request;
using UesrServices.Models.Response;

namespace UesrServices.KafkaServices;

public interface IKafkaUserService : IKafkaService<UserRequestDto, UserResponseDto> { }