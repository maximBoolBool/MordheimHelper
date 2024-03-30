using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SharedEntities.Helpers;
using SharedEntities.Models.DTO;
using SharedEntities.Models.DTO.Response;
using UesrServices.Helpers;
using UesrServices.KafkaServices;
using UesrServices.Models;
using UesrServices.Models.Queries;
using UesrServices.Models.Requests;
using UserEntities;
using UserEntities.Entities;

namespace UesrServices.Services.Impl;

/// <inheritdoc cref="IBandManager"/>
public class BandManager : IBandManager
{
    #region Fields

    private readonly IUserDbWorkerFactory _dbFactory;

    private readonly IKafkaBandService _kafkaService;

    private readonly IMapper _mapper;

    #endregion

    #region .ctor

    /// <inheritdoc cref="IBandManager"/>
    public BandManager(IUserDbWorkerFactory dbFactory, IKafkaBandService kafkaService, IMapper mapper)
    {
        _dbFactory = dbFactory;
        _kafkaService = kafkaService;
        _mapper = mapper;
    }

    #endregion
    
    #region Public Methods

    public async Task<BandResponse> CreateAsync(
        long userId,
        CreateBandRequest request,
        CancellationToken cancellationToken = default)
    {
        var kafkaRequest = new BandRequestDto
        {
            Id = request.TypeId
        };
        
        var newBand = _mapper.Map<BandEntity>(request);
        using var db = _dbFactory.CreateScopeDatabase();
        await db.Bands.CreateAsync(newBand, cancellationToken);
        await db.SaveChangesAsync(cancellationToken);
        
        var kafkaResponse = await _kafkaService.GetAsync(kafkaRequest, cancellationToken);

        return BandHelper.Create(kafkaResponse);
    }

    public Task<BandResponse> UpdateAsync(
        long userId,
        UpdateBandRequest request,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task DeletAsync(long userId, long bandId, CancellationToken cancellationToken)
    {
        using var db = _dbFactory.CreateScopeDatabase();
        await db.Bands.RemoveAsync(bandId, cancellationToken);
    }

    public Task<BandDto> GetAsync(long bandId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<SlimBandResponse[]> ListAsync(ListBandQuery query, CancellationToken cancellationToken)
    {
        using var db = _dbFactory.CreateScopeDatabase();
        var queries = db.Bands.CreateQuery();

        queries = FilterHelpers.Sm(queries, e => e.MaxPointCost, query.MaxCost );
        queries = FilterHelpers.Gr(queries, e => e.MaxPointCost, query.MinCost );

        var entities = await queries.ToArrayAsync(cancellationToken);

        return _mapper.Map<SlimBandResponse[]>(entities);
    }
    
    #endregion
}