using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinAppExpleShop.Web.Data.Entities;

namespace XamarinAppExpleShop.Web.Data
{

    using System.Linq;
    using System.Threading.Tasks;
    using XamarinAppExpleShop.Web.Data.Entities;

    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {
        }
    }
}
