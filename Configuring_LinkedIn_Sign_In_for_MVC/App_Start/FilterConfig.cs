using System.Web;
using System.Web.Mvc;

namespace Configuring_LinkedIn_Sign_In_for_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
