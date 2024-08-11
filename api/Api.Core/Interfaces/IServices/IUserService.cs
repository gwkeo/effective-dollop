using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IServices;

public interface IUserService
{
    Task<Guid> Create(UserDTO user);
    Task<List<UserDTO>> Read();
    Task<UserDTO> ReadById(Guid id);
    Task Update(Guid id, UserDTO updatedUserDto);
    Task Delete(Guid id);
}
