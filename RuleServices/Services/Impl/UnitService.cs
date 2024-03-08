using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RuleEntities;
using RuleEntities.Entities;
using RuleServices.Models.Dto;
using SharedEntities.Helpers;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Services.Impl;

internal class UnitService : IUnitService
{
    #region Fields

    private readonly IRuleDbWorkerFactory _dbWorkerFactory;

    private readonly IMapper _mapper;
    
    #endregion
    
    #region .ctor

    /// <summary>
    ///     .ctor
    /// </summary>
    public UnitService(IRuleDbWorkerFactory dbWorkerFactory, IMapper mapper)
    {
        _dbWorkerFactory = dbWorkerFactory;
        _mapper = mapper;
    }

    #endregion

    #region Public Methods
    
    public async Task<UnitResponse[]> ListAsync(UnitQuery query, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();

        var querieable = db.Units.CreateQuery();
        querieable = FilterHelpers.Eq(querieable, u => u.BandId, query.BandId);
        var entities = await querieable.ToArrayAsync(cancellationToken);

        return _mapper.Map<UnitResponse[]>(entities);
    }

    public async Task<UnitResponse> GetAsync(long id, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entity = await db.Units.CreateQuery()
            .Include(u => u.Armors)
            .Include(u => u.CloseCombatWeapons)
            .Include(u => u.RangeWeapons)
            .FirstAsync(u => u.Id == id, cancellationToken);
        
        return _mapper.Map<UnitResponse>(entity);
    }

    #endregion
}