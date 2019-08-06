using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAppExpleShop.Web.Data
{
    using Entities;


    //hace una herencia y despues implementa una interfaz
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        //el context que le llega se lo pase a la clase base que tiene herencia
        public ProductRepository(DataContext context) : base(context)
        {
        }


    }

}
