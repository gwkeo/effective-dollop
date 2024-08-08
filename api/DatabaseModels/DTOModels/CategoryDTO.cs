namespace DatabaseModels.DTOModels;

public class CategoryDTO
(
    Guid id,
    string name,
    string description
)
{
    public Guid Id { get; set; }
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
}