using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAppExpleShop.Web.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;


    //hace una herencia y despues implementa una interfaz
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext context;

        //el context que le llega se lo pase a la clase base que tiene herencia
        public ProductRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable GetAllWithUsers()
        {

            return this.context.Products.Include(p => p.User);

        }
    }

}
