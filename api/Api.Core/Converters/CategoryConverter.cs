using Api.Core.Entities.Models;
using Api.Core.Entities.DTOModels;

namespace Api.Core.Converters;

public static class CategoryConverter
{
    public static Category Convert(CategoryDTO _)
    {
        return new Category(id: _.Id, name: _.Name, description: _.Description);
    }

    public static CategoryDTO Convert(Category _)
    {
        return new CategoryDTO(id: _.Id, name: _.Name, description: _.Description);
    }

    public static List<Category> ConvertList(List<CategoryDTO> _)
    {
        var categories = new List<Category>();
        foreach (var category in _)
        {
            categories.Add(new Category
            (
                id: category.Id,
                name: category.Name,
                description: category.Description
            ));
        }

        return categories;
    }

    public static List<CategoryDTO> ConvertList(List<Category> _)
    {
        var categories = new List<CategoryDTO>();
        foreach (var category in _)
        {
            categories.Add(new CategoryDTO
            (
                id: category.Id,
                name: category.Name,
                description: category.Description
            ));
        }

        return categories;
    }
}