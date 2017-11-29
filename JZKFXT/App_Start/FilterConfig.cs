using JZKFXT.Utils;
using System.Web;
using System.Web.Mvc;

namespace JZKFXT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyErrorAttribute());

        }
    }
    //日志
    public class MyErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            LogHelper.Error(filterContext.Exception);
        }
    }
}
