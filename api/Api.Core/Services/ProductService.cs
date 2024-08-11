using System.Xml.XPath;
using Api.Core.Converters;
using Api.Core.Entities.DTOModels;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Interfaces.IServices;

namespace Api.Core.Services;

public class ProductService(IProductRepository repo) : IProductService
{
    private readonly IProductRepository _repo = repo;
    public async Task<Guid> Create(ProductDTO productDto)
    {
        var product = ProductConverter.Convert(productDto);
        return await _repo.CreateAsync(product);
    }

    public async Task<List<ProductDTO>> Read()
    {
        var products = await _repo.GetAsync() ?? throw new Exception("Список продуктов пуст");
        var result = ProductConverter.ConvertList(products);
        return result;
    }

    public async Task<ProductDTO> ReadById(Guid id)
    {
        var product = await _repo.GetAsync(id) ?? throw new ArgumentException("Продукт не найден");
        var result = ProductConverter.Convert(product);
        return result;
    }

    public async Task Update(Guid id, ProductDTO productDto)
    {
        var product = await _repo.GetAsync(id) ?? throw new ArgumentException("Продукт не найден");
        var updatedProduct = ProductConverter.Convert(productDto);
        updatedProduct.Id = id;
        await _repo.UpdateAsync(updatedProduct);
    }

    public async Task Delete(Guid id)
    {
        var product = await _repo.GetAsync(id) ?? throw new ArgumentException("Продукт не найден");
        await _repo.DeleteAsync(product);
    }
}