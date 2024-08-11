using Api.Infrastructure.Data;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Entities.DTOModels;
using Api.Core.Converters;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories;

public class CategoryRepository(ApplicationContext context) : ICategoryRepository
{
    private readonly ApplicationContext _context = context;

    public async Task<Guid> CreateAsync(CategoryDTO category)
    {
        var newCategory = CategoryConverter.Convert(category);
        await _context.Categories.AddAsync(newCategory);
        await _context.SaveChangesAsync();
        return newCategory.Id;
    }

    public async Task DeleteAsync(Guid id)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Категория не найдена");

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
    }

    public async  Task<List<CategoryDTO>?> GetAsync()
    {
        var categoryEntities = await _context.Categories.ToListAsync();
        List<CategoryDTO> categories = CategoryConverter.ConvertList(categoryEntities);
        return categories;
    }

    public async Task<CategoryDTO?> GetAsync(Guid id)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Категория не найдена");

        return CategoryConverter.Convert(category);
    }

    public async Task UpdateAsync(Guid id, CategoryDTO updatedCategory)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Категория не найдена");

        await _context.Categories
            .Where(x => x.Id == id)
            .ExecuteUpdateAsync(x => x
                .SetProperty(y => y.Id, updatedCategory.Id)
                .SetProperty(y => y.Name, updatedCategory.Name)
                .SetProperty(y => y.Description, updatedCategory.Description));
        
        await _context.SaveChangesAsync();
    }
}