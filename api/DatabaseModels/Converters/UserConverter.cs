using DatabaseModels.Models;
using DatabaseModels.DTOModels;

namespace DatabaseModels.Converters;

public static class UserConverter
{
    public static User Convert(UserDTO user)
    {
        var newUser = new User(user.Id, user.Name, user.Email, user.Password);
        return newUser;
    }

    public static UserDTO Convert(User user)
    {
        var newUser = new UserDTO(user.Id, user.Name, user.Email, user.Password);
        return newUser;
    }

    public static List<User> ConvertList(List<UserDTO> _)
    {
        var users = new List<User>();
        foreach (var user in _)
        {
            users.Add(new User(
                user.Id,
                user.Name,
                user.Email,
                user.Password));
        }

        return users;
    }

    public static List<UserDTO> ConvertList(List<User> _)
    {
        var users = new List<UserDTO>();
        foreach (var user in _)
        {
            users.Add(new UserDTO(
                user.Id, 
                user.Name, 
                user.Email, 
                user.Password));
        }

        return users;
    }
}