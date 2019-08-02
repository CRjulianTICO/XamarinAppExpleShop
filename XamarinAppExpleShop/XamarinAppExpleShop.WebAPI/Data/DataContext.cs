

namespace XamarinAppExpleShop.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using XamarinAppExpleShop.Web.Data.Entities;

    public class DataContext:DbContext
    {

        public DbSet<Product> Products { get; set; }


        public DataContext( DbContextOptions<DataContext> options)
            : base(options)
        {

        }

    }
}
