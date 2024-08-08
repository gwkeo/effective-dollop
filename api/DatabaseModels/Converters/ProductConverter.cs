using DatabaseModels.Models;
using DatabaseModels.DTOModels;

namespace DatabaseModels.Converters;

public class ProductConverter
{
    public Product Convert(ProductDTO product)
    {
        return new Product
        (
            product.Id, 
            product.CategoryId, 
            product.Price, 
            product.Name, 
            product.Description
        );
    }

    public ProductDTO Convert(Product _)
    {
        return new ProductDTO
        (
            _.Id,
            _.CategoryId,
            _.Price,
            _.Name,
            _.Description
        );
    }

    public List<Product> ConvertList(List<ProductDTO> _)
    {
        var users = new List<Product>();
        foreach (var user in _)
        {
            users.Add(new Product
            (
                user.Id,
                user.CategoryId,
                user.Price,
                user.Name,
                user.Description
            ));
        }

        return users;
    }

    public List<ProductDTO> ConvertList(List<Product> _)
    {
        var users = new List<ProductDTO>();
        foreach (var user in _)
        {
            users.Add(new ProductDTO
            (
                user.Id,
                user.CategoryId,
                user.Price,
                user.Name,
                user.Description
            ));
        }

        return users;
    }
}