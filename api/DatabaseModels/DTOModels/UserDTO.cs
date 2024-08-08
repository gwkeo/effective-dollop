namespace DatabaseModels.DTOModels;

public class UserDTO
(
    Guid id,
    string name,
    string email,
    string password
)
{

    public Guid Id { get; set; } = id;

    public string Name { get; set; } = name;

    public string Email { get; set; } = email;

    public string Password { get; set; } = password;

}