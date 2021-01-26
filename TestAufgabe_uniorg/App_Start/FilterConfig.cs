using System.Web;
using System.Web.Mvc;

namespace TestAufgabe_uniorg
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
