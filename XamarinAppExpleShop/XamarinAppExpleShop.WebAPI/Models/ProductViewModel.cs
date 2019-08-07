

namespace XamarinAppExpleShop.Web.Models
{

    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using XamarinAppExpleShop.Web.Data.Entities;
    public class ProductViewModel:Product
    {
        [Display(Name="Image")]
        public IFormFile ImageFile { get; set; }
    }
}
