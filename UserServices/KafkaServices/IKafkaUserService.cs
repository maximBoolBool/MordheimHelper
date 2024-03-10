using KafkaServices;
using KafkaServices.Impl;
using SharedEntities.Models.DTO.Request;
using SharedEntities.Models.DTO.Response;

namespace UesrServices.KafkaServices;

public interface IKafkaUserService : IKafkaService<UserQueryDto, UserResponseDto> { }