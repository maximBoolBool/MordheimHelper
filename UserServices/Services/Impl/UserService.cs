using System.Net;
using AutoMapper;
using SharedEntities.Models;
using SharedEntities.Models.DTO.Request;
using UserEntities.Entities;
using UserEntities.Repositories;

namespace UesrServices.Services.Impl;

/// <inheritdoc cref="IUserService"/>
public class UserService : IUserService
{
    #region Fields
    
    private readonly IUserRepository _repository;

    private readonly IMapper _mapper;

    #endregion

    #region .ctor

    /// <summary>
    ///     .ctor
    /// </summary>
    public UserService(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    #endregion
    
    #region Public methods

    /// <inheritdoc cref="IUserService"/>
    public async Task<bool> RegistrateUserAsync(UserQueryDto userQuery, CancellationToken cancellationToken)
    {
        var oldUser = await _repository.FindByLogin(userQuery.Login, cancellationToken);

        if (oldUser != null)
        {
            throw new ErrorException(HttpStatusCode.Conflict, "User already exsit");
        }

        var newUser = _mapper.Map<UserEntity>(userQuery);

        await _repository.CreateAsync(newUser, cancellationToken);
        return true;
    }

    /// <inheritdoc cref="IUserService"/>
    public async Task<bool> UpdateUserPasswordAsync(UserQueryDto user, CancellationToken cancellationToken)
    {
        return true;
    }

    /// <inheritdoc cref="IUserService"/>
    public Task<bool> AuthenticateAsync(UserQueryDto query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IUserService"/>
    public async Task<bool> DeleteUserAsync(long id, CancellationToken cancellationToken)
    {
        var user = await _repository.FindById(id, cancellationToken);

        if (user == null)
        {
            throw new ErrorException(HttpStatusCode.NotFound, "Not found");
        }

        await _repository.Remove(user.Id, cancellationToken);
        
        return true;
    }

    /// <inheritdoc cref="IUserService"/>
    public async Task LogoffAsync(long id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IUserService"/>
    public async Task RefreshAsync()
    {
        throw new NotImplementedException();
    }

    #endregion
}