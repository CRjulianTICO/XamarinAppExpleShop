using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAppExpleShop.Web.Helpers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Net;

    public class GeneralErrorViewResult : ViewResult
    {
        public GeneralErrorViewResult(string viewName,string error)
        {
            ViewName = viewName;
            String Error = error;
        }
    }
}
