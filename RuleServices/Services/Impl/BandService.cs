using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RuleEntities;
using RuleServices.Models;
using RuleServices.Models.Dto;

namespace RuleServices.Services.Impl;

internal class BandService : IBandService
{
    #region Fields

    private readonly IRuleDbWorkerFactory _dbWorkerFactory;

    private readonly IMapper _mapper;

    #endregion

    #region .ctor
    
    public BandService(IRuleDbWorkerFactory dbWorkerFactory, IMapper mapper)
    {
        _dbWorkerFactory = dbWorkerFactory;
        _mapper = mapper;
    }

    #endregion
    
    #region Public methods

    public async Task<BandModel[]> ListAsync(BandListQuery query, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entities = await db.Bands.CreateQuery().ToArrayAsync(cancellationToken);
        return _mapper.Map<BandModel[]>(entities);
    }
    
    public async Task<BandModel> GetAsync(long id, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entities = await db.Bands.FindById(id, cancellationToken);
        return _mapper.Map<BandModel>(entities);
    }

    #endregion
}