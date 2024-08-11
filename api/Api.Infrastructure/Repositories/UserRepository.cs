using Api.Infrastructure.Data;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Entities.Models;
using Api.Core.Converters;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories;

public class UserRepository(ApplicationContext context) : IUserRepository
{
    private readonly ApplicationContext _context = context;
    public async Task<List<User>?> GetAsync()
    {
        return await _context.Users.ToListAsync();
    }
    
    public async Task<User?> GetAsync(Guid id)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Guid> CreateAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return user.Id;
    }

    public async Task UpdateAsync(User updatedUser)
    {
        await _context.Users
            .Where(x => x.Id == updatedUser.Id)
            .ExecuteUpdateAsync(x => x
                .SetProperty(y => y.Email, updatedUser.Email)
                .SetProperty(y => y.Name, updatedUser.Name)
                .SetProperty(y => y.Password, updatedUser.Password));

        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}