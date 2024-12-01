using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;

namespace Core.IRepository
{
    public interface ICategoryRepository
    {
        List<Category>? GetAsync();

        Category GetAsync(int id);

        void CreateAsync(Category category);

        void UpdateAsync(int id, Category category);
        
        void DeleteAsync(int id);
    }
}
