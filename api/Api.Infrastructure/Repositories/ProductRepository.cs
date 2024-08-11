using Api.Infrastructure.Data;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Entities.DTOModels;
using Api.Core.Converters;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories;
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context = new ApplicationContext();

        public async Task<Guid> CreateAsync(ProductDTO product)
        {
            var newProduct = ProductConverter.Convert(product);
            await _context.AddAsync(newProduct);
            await _context.SaveChangesAsync();
            return newProduct.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Продукт не найден");

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProductDTO>?> GetAsync()
        {
            var products = await _context.Products.ToListAsync();
            var result = ProductConverter.ConvertList(products);
            return result;
        }

        public async Task<ProductDTO?> GetAsync(Guid id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Продукт не найден");

            var result = ProductConverter.Convert(product);
            return result;
        }

        public async Task UpdateAsync(Guid id, ProductDTO newProduct)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Продукт не найден");

            await _context.Products
                .Where(x => x.Id == id)
                .ExecuteUpdateAsync(x => x
                    .SetProperty(y => y.Id, newProduct.Id)
                    .SetProperty(y => y.Name, newProduct.Name)
                    .SetProperty(y => y.Price, newProduct.Price)
                    .SetProperty(y => y.CategoryId, newProduct.CategoryId)
                    .SetProperty(y => y.Description, newProduct.Description));

            await _context.SaveChangesAsync();
        }
    }
}
