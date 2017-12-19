using JZKFXT.Filter;
using JZKFXT.Utils;
using System;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace JZKFXT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
    
    
}
