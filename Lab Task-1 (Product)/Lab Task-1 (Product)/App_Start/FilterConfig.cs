using System.Web;
using System.Web.Mvc;

namespace Lab_Task_1__Product_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
