using AutoMapper;
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

    private IUserDbWorkerFactory _dbFactory;

    private IKafkaBandService _kafkaService;

    private IMapper _mapper;

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
        var kafkaRequest = new BandRequestDTO
        {
            Id = request.TypeId
        };
        
        var newBand = _mapper.Map<BandEntity>(request);
        using var db = _dbFactory.CreateScopeDatabase();
        await db.Bands.CreateAsync(newBand, cancellationToken);
        
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

    public Task DeletAsync(long userId, long bandId)
    {
        throw new NotImplementedException();
    }

    public Task<BandDto> GetAsync(long bandId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<BandDto[]> ListAsync(ListBandQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
    
    #endregion
}