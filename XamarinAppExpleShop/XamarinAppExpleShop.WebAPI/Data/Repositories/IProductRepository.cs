﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace XamarinAppExpleShop.Web.Data
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Threading.Tasks;
    using XamarinAppExpleShop.Web.Data.Entities;

    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();

        IEnumerable<SelectListItem> GetComboProducts();
    }






}
