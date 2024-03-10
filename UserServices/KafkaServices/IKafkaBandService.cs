using KafkaServices;
using SharedEntities.Models.DTO;
using SharedEntities.Models.DTO.Response;
using UesrServices.Models;

namespace UesrServices.KafkaServices;

/// <summary>
///     Сервис для получения правил банд
/// </summary>
public interface IKafkaBandService : IKafkaService<BandRequestDTO, BandDto> { }