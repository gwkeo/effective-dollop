using Api.Infrastructure.Data;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Converters;
using Api.Core.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories;
public class ProductRepository : IProductRepository
{
    private readonly ApplicationContext _context = new ApplicationContext();

    public async Task<Guid> CreateAsync(Product product)
    {
        await _context.AddAsync(product);
        await _context.SaveChangesAsync();
        return product.Id;
    }

    public async Task DeleteAsync(Product product)
    {
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Product>?> GetAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> GetAsync(Guid id)
    {
        return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task UpdateAsync(Product product)
    {
        await _context.Products
            .Where(x => x.Id == product.Id)
            .ExecuteUpdateAsync(x => x
                .SetProperty(y => y.Id, product.Id)
                .SetProperty(y => y.Name, product.Name)
                .SetProperty(y => y.Price, product.Price)
                .SetProperty(y => y.CategoryId, product.CategoryId)
                .SetProperty(y => y.Description, product.Description));

        await _context.SaveChangesAsync();
    }
}
