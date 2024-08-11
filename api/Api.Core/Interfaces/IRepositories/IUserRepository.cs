using Api.Core.Entities.Models;

namespace Api.Core.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        Task<List<User>?> GetAsync();

        Task<User?> GetAsync(Guid id);

        Task<Guid> CreateAsync(User user);

        Task UpdateAsync(User updatedUser);

        Task DeleteAsync(User user);
    }
}
