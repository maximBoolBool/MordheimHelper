using Microsoft.AspNetCore.Mvc;
using SharedEntities.Models.DTO.Request;
using UesrServices.KafkaServices;

namespace UserService.Controllers;

[Route("api/units")]
public class UnitController : Controller
{
    private readonly IKafkaUnitService _kafkaService;
    
    public UnitController(IKafkaUnitService kafkaService)
    {
        _kafkaService = kafkaService;
    }

    [HttpGet]
    public async Task Get(CancellationToken cancellationToken)
    {
        await _kafkaService.Producer.ProduceAsync( new UnitRequest(), cancellationToken);
        Console.WriteLine("Succes send message");
    }
}