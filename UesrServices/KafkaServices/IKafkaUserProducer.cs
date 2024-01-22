using KafkaServices;
using UesrServices.Models.Request;

namespace UesrServices.KafkaServices;

public interface IKafkaUserProducer : IKafkaProducer<UserRequestDto> { } 