using AutoMapper;
using RuleEntities.Repositories;
using RuleServices.Models;

namespace RuleServices.Services.Impl;

public class BandService : IBandService
{
    private readonly IRuleDatabaseWorker _db;

    private readonly IMapper _mapper;

    public BandService(IRuleDatabaseWorker db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<BandModel[]> ListAsync(CancellationToken cancellationToken)
    {
        var entities = await _db.Bands.ListAsync();
        var response = _mapper.Map<BandModel[]>(entities);
        return response;
    }

    public async Task<BandModel> GetAsync(long id, CancellationToken cancellationToken)
    {
        var entity = await _db.Bands.FindById(id, cancellationToken);
        var response = _mapper.Map<BandModel>(entity);
        return response;
    }
    
}