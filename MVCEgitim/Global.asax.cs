using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCEgitim
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() // Uygulama çalıştığında aşağıdaki metotları çalıştır
        {
            AreaRegistration.RegisterAllAreas(); // bölgeleri aktif et
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); // filtreleri aktif et
            RouteConfig.RegisterRoutes(RouteTable.Routes); // Routing i aktif et
            BundleConfig.RegisterBundles(BundleTable.Bundles); // Bundles (Css, js kütüphaneleri) ı aktif et
        }
    }
}
