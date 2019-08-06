﻿

namespace XamarinAppExpleShop.Web.Data
{

    using System.Collections.Generic;
    using System.Threading.Tasks;
    using XamarinAppExpleShop.Web.Data.Entities;

    public interface IRepository
    {
        void AddProduct(Product product);

        Product GetProduct(int id);

        IEnumerable<Product> GetProducts();

        bool ProductExists(int id);

        void RemoveProduct(Product product);

        Task<bool> SaveAllAsync();

        void UpdateProduct(Product product);
    }
}