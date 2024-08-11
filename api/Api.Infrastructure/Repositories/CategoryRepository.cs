using Api.Infrastructure.Data;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories;

public class CategoryRepository(ApplicationContext context) : ICategoryRepository
{
    private readonly ApplicationContext _context = context;


    public async Task<List<Category>?> GetAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category?> GetAsync(Guid id)
    {
        return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Guid?> CreateAsync(Category category)
    {
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return category.Id;
    }

    public async Task UpdateAsync(Category updatedCategory)
    {
        await _context.Categories
            .Where(x => x.Id == updatedCategory.Id)
            .ExecuteUpdateAsync(x => x
                .SetProperty(y => y.Description, updatedCategory.Description)
                .SetProperty(y => y.Description, updatedCategory.Description));
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Category category)
    {
        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
    }
}