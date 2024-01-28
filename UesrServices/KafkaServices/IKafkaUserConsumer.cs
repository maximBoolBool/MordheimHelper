using KafkaServices;
using SharedEntities.Models.DTO.Response;

namespace UesrServices.KafkaServices;

public interface IKafkaUserConsumer : IKafkaConsumer<UserResponseDto> { }