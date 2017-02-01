using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC_Ainnaya
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
