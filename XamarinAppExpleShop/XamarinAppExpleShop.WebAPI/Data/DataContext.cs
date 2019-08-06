

namespace XamarinAppExpleShop.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using XamarinAppExpleShop.Web.Data.Entities;

    public class DataContext : IdentityDbContext<User>
    {



        public DbSet<Product> Products { get; set; }


        public DataContext( DbContextOptions<DataContext> options)
            : base(options)
        {

        }

    }
}
