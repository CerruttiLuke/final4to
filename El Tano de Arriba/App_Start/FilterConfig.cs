using System.Web;
using System.Web.Mvc;

namespace El_Tano_de_Arriba
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
