using Core.IRepository;
using DatabaseModels;
using DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository
{
    public class UserRepository : IUserRepository
    {
        public void CreateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<User>? GetAsync()
        {
            throw new NotImplementedException();
        }

        public User? GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(int id, User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
