using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinAppExpleShop.Web.Data.Entities;

namespace XamarinAppExpleShop.Web.Data
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {

            var productos = new List<Product>();
            productos.Add(new Product {Id=1, Name = "Uno", Price=250 });
            productos.Add(new Product { Id = 2, Name = "Dos", Price = 20 });
            productos.Add(new Product { Id = 3, Name = "Tres", Price = 50 });
            productos.Add(new Product { Id = 4, Name = "Cuatro", Price = 25 });

            return productos;
        }

        public bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
