using AutoMapper;
using RuleEntities;
using RuleServices.Models;
using RuleServices.Models.Dto;
using SharedEntities.Models.DTO.Response;

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

    public async Task<RangeWeaponDto> GetAsync(long id, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entity = await db.RangeWeapons.FindById(id, cancellationToken);
        return _mapper.Map<RangeWeaponDto>(entity);
    }

    public async Task<RangeWeaponDto[]> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entities = await db.RangeWeapons.ListAsync(cancellationToken);
        return _mapper.Map<RangeWeaponDto[]>(entities);
    }
    
    #endregion
}