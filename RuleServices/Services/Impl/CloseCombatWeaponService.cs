using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RuleEntities;
using RuleServices.Models;
using RuleServices.Models.Dto;

namespace RuleServices.Services.Impl;

internal class CloseCombatWeaponService : ICloseCombatWeaponService
{
    #region Fields

    private IMapper _mapper;

    private IRuleDbWorkerFactory _dbWorkerFactory;

    #endregion

    #region .ctor
    
    public CloseCombatWeaponService(IMapper mapper, IRuleDbWorkerFactory dbWorkerFactory)
    {
        _mapper = mapper;
        _dbWorkerFactory = dbWorkerFactory;
    }
    
    #endregion

    #region Public fields

    public async Task<CloseWeaponModel> GetAsync(long id, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entity = await db.CloseCombatWeapons.FindById(id, cancellationToken);
        return _mapper.Map<CloseWeaponModel>(entity);
    }

    public async Task<CloseWeaponModel[]> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken)
    {
        using var db = _dbWorkerFactory.CreateScopeDatabase();
        var entity = await db.CloseCombatWeapons.CreateQuery()
            .ToArrayAsync(cancellationToken);
        return _mapper.Map<CloseWeaponModel[]>(entity);
    }
    
    #endregion
}