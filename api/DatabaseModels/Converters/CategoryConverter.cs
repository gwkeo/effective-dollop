using DatabaseModels.Models;
using DatabaseModels.DTOModels;

namespace DatabaseModels.Converters;

public class CategoryConverter
{
    public Category Convert(CategoryDTO _)
    {
        return new Category(id: _.Id, name: _.Name, description: _.Description);
    }

    public CategoryDTO Convert(Category _)
    {
        return new CategoryDTO(id: _.Id, name: _.Name, description: _.Description);
    }

    public List<Category> ConvertList(List<CategoryDTO> _)
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

    public List<CategoryDTO> ConvertList(List<Category> _)
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