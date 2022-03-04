using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc08ViewToControllerController : Controller
    {
        // GET: Mvc08ViewToController
        public ActionResult Index(string txtAra) // Mvc de ön yüzle eşleşmeler bu şekilde textbox ile aynı isimde parametre kullanılarak yapılıyor
        {
            ViewBag.GetVerisi = "Aranan kelime : " + txtAra;
            return View();
        }
        [HttpPost] // Aşağıdaki Index action unun türünün post metodu olduğunu ayarladık
        public ActionResult Index(string text1, string liste, bool cbOnay) // Mvc de ön yüzdeki elemanların name alanıyla eşleşme yapılır Id ile değil!
        {
            //1. yöntem parametrelerden gelen veri;
            ViewBag.Mesaj = "textboxdan gelen veri : " + text1;
            ViewData["Vdata"] = "checkboxdan gelen veri : " + cbOnay;
            TempData["Tdata"] = "listboxdan gelen veri : " + liste;

            //2. yöntem Request.Form ile veri alma
            var txt = Request.Form["text1"];
            var ddl = Request.Form["liste"];
            //var chb = Request.Form["cbOnay"]; true,false dönüyor
            var chb = Request.Form.GetValues("cbOnay")[0];

            ViewBag.Mesaj2 = "textboxdan gelen veri : " + txt;
            ViewData["Vdata2"] = "checkboxdan gelen veri : " + chb;
            TempData["Tdata2"] = "listboxdan gelen veri : " + ddl;

            return View();
        }
    }
}