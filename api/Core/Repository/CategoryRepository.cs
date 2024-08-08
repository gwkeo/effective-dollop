using Core.IRepository;
using DatabaseContext;
using DatabaseModels.Converters;
using DatabaseModels.DTOModels;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository;

public class CategoryRepository(ApplicationContext context) : ICategoryRepository
{
    private readonly ApplicationContext _context = context;

    public async  Task<List<CategoryDTO>?> GetAsync()
    {
        var categoryEntities = await _context.Categories.ToListAsync();
        List<CategoryDTO> categories = CategoryConverter
    }
}