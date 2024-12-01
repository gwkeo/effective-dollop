using Core.IRepository;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void CreateAsync(Product product)
        {
            using ( var db = new DatabaseContext.ApplicationDBContext())
            {
                db.Products.Add(product);
            }
        }

        public void DeleteAsync(int id)
        {
            using ( var db = new DatabaseContext.ApplicationDBContext() )
            {
                
            }
        }

        public List<Product>? GetAsync()
        {
            throw new NotImplementedException();
        }

        public Product? GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
