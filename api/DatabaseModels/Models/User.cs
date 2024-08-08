namespace DatabaseModels.Models;

public class User(
    Guid id,
    string name,
    string email,
    string password
    )
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}
