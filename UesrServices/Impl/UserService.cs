using System.Net;
using AutoMapper;
using SharedEntities.Models;
using UesrServices.Models;
using UserEntities.Entities;
using UserEntities.Repositories;

namespace UesrServices.Impl;

/// <inheritdoc cref="IUserService"/>
public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    private readonly IMapper _mapper;

    public UserService(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    /// <inheritdoc cref="IUserService"/>
    public async Task<bool> RegistrateUserAsync(UserRequestDto userRequest, CancellationToken cancellationToken)
    {
        var oldUser = await _repository.FindByLogin(userRequest.Login, cancellationToken);

        if (oldUser != null)
        {
            throw new ErrorException(HttpStatusCode.Conflict, "User already exsit");
        }

        var newUser = _mapper.Map<UserEntity>(userRequest);

        await _repository.Create(newUser, cancellationToken);
        return true;
    }

    /// <inheritdoc cref="IUserService"/>
    public async Task<bool> UpdateUserAsync(UserRequestDto user, CancellationToken cancellationToken)
    {
           
        return true;
    }

    /// <inheritdoc cref="IUserService"/>
    public Task<bool> AuthenticateAsync()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IUserService"/>
    public async Task<bool> DeleteUserAsync(long id, CancellationToken cancellationToken)
    {
        var user = await _repository.FindById(id, cancellationToken);

        if (user != null)
        {
            throw new ErrorException(HttpStatusCode.NotFound, "Not found");
        }

        await _repository.Remove(user.Id, cancellationToken);
        
        return true;
    }
}