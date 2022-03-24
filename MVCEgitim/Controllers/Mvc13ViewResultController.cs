using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc13ViewResultController : Controller
    {
        // GET: Mvc13ViewResult
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult Index2()
        {
            //return Redirect("/Home/Index"); // 1. örnek anasayfaya yönlendirme
            //return Redirect("/Home/Index?kelime=monitör");
            return Redirect("https://www.google.com/"); // dış linke yönlendirme
        }
        public RedirectToRouteResult Index3()
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "Index", id = 5 });
        }
        public PartialViewResult KategorileriGetirPartial()
        {
            return PartialView("_KategorilerPartial");
        }
        public PartialViewResult KategorileriModelleGetirPartial()
        {
            List<string> kategoriler = new List<string>()
            {
                "Bilgisayar",
                "Monitörler",
                "Klavyeler"
            };

            return PartialView("_KategorilerPartial2", kategoriler); // _KategorilerPartial2 ismindeki sayfaya model olarak kullanacağı kategoriler isimli listeyi gönderdik
        }
        public FileResult PdfDosyaIndir()
        {
            string dosyayolu = Server.MapPath("/ariBilgi.pdf"); // indirilecek dosya adresi
            return new FilePathResult(dosyayolu, "application/pdf");
        }
        public FileStreamResult MetinDosyasiIndir()
        {
            string metin = "FileStreamResult ile MetinDosyasiIndir";

            MemoryStream memory = new MemoryStream();
            byte[] bytes = Encoding.UTF8.GetBytes(metin);

            memory.Write(bytes, 0, bytes.Length);
            memory.Position = 0;

            FileStreamResult result = new FileStreamResult(memory, "text/plain");
            result.FileDownloadName = "deneme.txt";

            return result;
        }

        public JavaScriptResult JsResult()
        {
            string js = "alert('JsResult Çalıştı!');";

            return JavaScript(js);
        }
        public JavaScriptResult jsButtonClick()
        {
            string js = "function button_click(){ alert('jsButtonClick Çalıştı!');}";

            return JavaScript(js);
        }
        public JsonResult Index4()
        {
            Kullanici kullanici = new Kullanici
            {
                Id = 5,
                Ad = "Ali",
                Email = "mail",
                KullaniciAdi = "admin"
            };
            return Json(kullanici, JsonRequestBehavior.AllowGet);
        }
        public ContentResult XmlContentResult()
        {
            var xml = @"
                <kullanicilar>
                    <kullanici>
                        <Id>9</Id>
                        <Ad>Murat</Ad>
                        <Soyad>Yılmaz</Soyad>
                        <Email>null</Email>
                    </kullanici>
                    <kullanici>
                        <Id>10</Id>
                        <Ad>Mesut</Ad>
                        <Soyad>Ilıca</Soyad>
                        <Email>null</Email>
                    </kullanici>
                </kullanicilar>";
            return Content(xml, "application/xml");
        }
    }
}