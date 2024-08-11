using System.Data;
using Api.Core.Converters;
using Api.Core.Entities.DTOModels;
using Api.Core.Interfaces.IServices;
using Api.Core.Interfaces.IRepositories;

namespace Api.Core.Services;

public class UserService(IUserRepository repo) : IUserService
{
    private readonly IUserRepository _repo = repo;

    public async Task<Guid> Create(UserDTO user)
    {
        var newUser = UserConverter.Convert(user);
        return await _repo.CreateAsync(newUser);
    }

    public async Task Delete(Guid id)
    {
        var user = await _repo.GetAsync(id) ?? throw new ArgumentException("Пользователь не найден");
        await _repo.DeleteAsync(user);
    }

    public async Task<List<UserDTO>> Read()
    {
        var users = await _repo.GetAsync() ?? throw new Exception("Список пользователей пуст");
        var result = UserConverter.ConvertList(users);
        return result;
    }

    public async Task<UserDTO> ReadById(Guid id)
    {
        var user = await _repo.GetAsync(id) ?? throw new ArgumentException("Пользователь не найден");
        var result = UserConverter.Convert(user);
        return result;
    }

    public async Task Update(Guid id, UserDTO updatedUserDto)
    {
        var user = await _repo.GetAsync(id) ?? throw new ArgumentException("Пользователь не найден");
        var updatedUser = UserConverter.Convert(updatedUserDto);
        updatedUser.Id = id;
        await _repo.UpdateAsync(updatedUser);
    }
}
