using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;

namespace Core.IRepository
{
    public interface IProductRepository
    {
        List<Product>? GetAsync();

        Product? GetAsync(int id); 
        
        void CreateAsync(Product product);
        
        void UpdateAsync(int id, Product product);
        
        void DeleteAsync(int id);
    }
}
