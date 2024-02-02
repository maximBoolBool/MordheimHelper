using AutoMapper;
using RuleEntities;
using RuleServices.Models;
using RuleServices.Models.Dto;

namespace RuleServices.Services.Impl;

internal class RangeWeaponService : IRangeWeaponService
{
    #region Fields
    
    private readonly IRuleDbWorkerFactory _dbWorkerFactory;

    private readonly IMapper _mapper;
    
    #endregion

    #region .ctor

    public RangeWeaponService(IRuleDbWorkerFactory dbWorkerFactory, IMapper mapper)
    {
        _dbWorkerFactory = dbWorkerFactory;
        _mapper = mapper;
    }
    
    #endregion

    #region Public methods

    public async Task<RangeWeaponModel> GetAsync(long id, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entity = await db.RangeWeapons.FindById(id, cancellationToken);
        return _mapper.Map<RangeWeaponModel>(entity);
    }

    public async Task<RangeWeaponModel[]> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entities = await db.RangeWeapons.ListAsync(cancellationToken);
        return _mapper.Map<RangeWeaponModel[]>(entities);
    }
    
    #endregion
}