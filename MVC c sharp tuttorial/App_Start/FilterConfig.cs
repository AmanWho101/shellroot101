using System.Web;
using System.Web.Mvc;

namespace MVC_c_sharp_tuttorial
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
