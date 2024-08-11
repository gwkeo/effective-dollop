using Api.Core.Entities.DTOModels;
using Api.Core.Interfaces.IServices;
using Api.Core.Interfaces.IRepositories;

namespace Api.Core.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repo;
    public async Task<Guid> Create(UserDTO user) => await _repo.CreateAsync(user);

    public async Task Delete(Guid id)
    {
        try
        {
            await _repo.DeleteAsync(id);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public Task<List<UserDTO>> Read()
    {
        throw new NotImplementedException();
    }

    public Task<UserDTO> ReadById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Guid id, UserDTO updatedUser)
    {
        throw new NotImplementedException();
    }
}
