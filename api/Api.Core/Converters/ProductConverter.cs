using Api.Core.Entities.Models;
using Api.Core.Entities.DTOModels;

namespace Api.Core.Converters;

public static class ProductConverter
{
    public static Product Convert(ProductDTO product)
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

    public static ProductDTO Convert(Product _)
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

    public static List<Product> ConvertList(List<ProductDTO> _)
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

    public static List<ProductDTO> ConvertList(List<Product> _)
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