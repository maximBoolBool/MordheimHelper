using AutoMapper;
using RuleEntities.Repositories;
using RuleServices.Models;

namespace RuleServices.Services.Impl;

public class BandService : IBandService
{
    private readonly IRuleDatabase _db;

    private readonly IMapper _mapper;

    public BandService(IRuleDatabase db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<BandModel[]> List()
    {
        var entities = await _db.Bands.ListAsync();
        var response = _mapper.Map<BandModel[]>(entities);
        return response;
    }
}