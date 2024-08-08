using Core.IRepository;
using DatabaseContext;
using DatabaseModels.Converters;
using DatabaseModels.DTOModels;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository;

public class UserRepository(ApplicationContext context) : IUserRepository
{
    private readonly ApplicationContext _context = context;
    public async Task<List<UserDTO>?> GetAsync()
    {
        var userEntities = await _context.Users.ToListAsync();
        List<UserDTO> users = UserConverter.ConvertList(userEntities);
        return users;
    }
    public async Task<UserDTO?> GetAsync(Guid id)
    {
        var userEntity = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        
        if (userEntity == null)
        {
            throw new ArgumentException("Пользователь не найден");
        }
        
        UserDTO user = UserConverter.Convert(userEntity);
        return user;
    }

    public async Task<Guid> CreateAsync(UserDTO user)
    {
        var newUser = UserConverter.Convert(user);
        await _context.Users.AddAsync(newUser);
        await _context.SaveChangesAsync();
        return user.Id;
    }

    public async Task UpdateAsync(Guid id, UserDTO updatedUser)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (user == null)
        {
            throw new ArgumentException("Пользователь не найден");
        }

        await _context.Users
            .Where(x => x.Id == id)
            .ExecuteUpdateAsync(x => x
                .SetProperty(y => y.Email, updatedUser.Email)
                .SetProperty(y => y.Name, updatedUser.Name)
                .SetProperty(y => y.Password, updatedUser.Password));

    }

    public async Task DeleteAsync(Guid id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (user == null)
        {
            throw new ArgumentException("Пользователь не найден");
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}