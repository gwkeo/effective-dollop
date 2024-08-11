using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        Task<List<UserDTO>?> GetAsync();

        Task<UserDTO?> GetAsync(Guid id);

        Task<Guid> CreateAsync(UserDTO user);

        Task UpdateAsync(Guid id, UserDTO updatedUser);

        Task DeleteAsync(Guid id);
    }
}
