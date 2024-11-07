using System.Web;
using System.Web.Mvc;

namespace DangTaiNguyen_2210900052_project2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
