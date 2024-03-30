using AutoMapper;
using RuleEntities;
using RuleServices.Models;
using RuleServices.Models.Dto;
using SharedEntities.Models.DTO.Response;

namespace RuleServices.Services.Impl;

internal class ArmorService : IArmorService
{
    #region Fields
    
    private readonly IRuleDbWorkerFactory _dbFactory;

    private readonly IMapper _mapper;
    
    #endregion

    #region .ctor

    public ArmorService(IRuleDbWorkerFactory dbFactory, IMapper mapper)
    {
        _dbFactory = dbFactory;
        _mapper = mapper;
    }
    
    #endregion

    #region Public methods

    public async Task<ArmorDto> GetAsync(long id, CancellationToken cancellationToken)
    {
        using var db = _dbFactory.CreateScopeDatabase();
        var entity = await db.Armors.FindById(id, cancellationToken);
        return _mapper.Map<ArmorDto>(entity);
    }

    public async Task<ArmorDto[]> ListAsync(EquepmentListQuery query, CancellationToken cancellationToken)
    {
        using var db = _dbFactory.CreateScopeDatabase();
        var entities = await db.Armors.ListAsync(cancellationToken);
        return _mapper.Map<ArmorDto[]>(entities);
    }
    
    #endregion
}