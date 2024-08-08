namespace DatabaseModels.DTOModels;

public class ProductDTO(
    Guid id,
    Guid categoryId,
    int price,
    string name,
    string description
    )
{

    public Guid Id { get; set; } = id;

    public Guid CategoryId { get; set; } = categoryId;

    public int Price { get; set; } = price;

    public string Name { get; set; } = name;

    public string Description { get; set; } = description;

}