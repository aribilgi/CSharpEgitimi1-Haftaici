using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // Burası views klasöründeki Index isimli view için çalışır
        {
            return View(); // Burası home controller ın index actionuna gelen istekte geriye view(Sayfaların ön yüzü) döndürür
        }

        public ActionResult About() // Geriye Views altındaki About isimli view ı döndürür
        {
            ViewBag.Message = "Burası sayfa ön yüzüne veri gönderebileceğimiz nesne nin içi.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Mvc de 1 controller da 1 den fazla action ile view çalıştırabiliriz";

            return View();
        }
    }
}