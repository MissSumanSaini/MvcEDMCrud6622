using System.Web;
using System.Web.Mvc;

namespace MvcEDMCrud6622
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
