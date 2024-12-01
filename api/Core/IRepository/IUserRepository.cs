using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace Core.IRepository
{
    public interface IUserRepository
    {
        List<User>? GetAsync();

        User? GetAsync(int id);

        void CreateAsync(User user);

        void UpdateAsync(int id, User updatedUser);

        void DeleteAsync(int id);
    }
}
