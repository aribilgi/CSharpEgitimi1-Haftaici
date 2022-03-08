using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc09ModelBindingController : Controller
    {
        // GET: Mvc09ModelBinding
        public ActionResult Index()
        {
            var sayfaModeli = new AnasayfaViewModel
            {
                Adres = new Adres { Id = 25, Sehir = "Erzurum", Ilce = "Ilıca", AcikAdres = "Cami sk. no:18" },
                Kullanici = new Kullanici { Id = 34, Ad = "Murat", Soyad = "Yılmaz", Email = "nusr@doner.co", KullaniciAdi = "admin", Sifre = "123456" }
            };
            return View(sayfaModeli); // yukarda içini doldurduğumuz sayfa modelini ön yüze gönderiyoruz
        }
        public ActionResult Kullanici() // GET Metodu
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                KullaniciAdi = "Muro",
                Sifre = "Çeto25"
            };
            return View(kullanici); // ön yüz view ına kullanıcı nesnesini gönderdik
        }
        [HttpPost]
        public ActionResult Kullanici(Kullanici kullanici)
        {
            ViewBag.Mesaj = "Kullanıcı Adı : " + kullanici.Ad;
            ViewData["Vdata"] = "Kullanıcı Soyadı : " + kullanici.Soyad;
            TempData["Tdata"] = "Kullanıcı Email : " + kullanici.Email;
            return View(kullanici);
        }
        public ActionResult Adres() // Get 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adres(Adres adres)
        {
            ViewBag.Mesaj = "Şehir : " + adres.Sehir;
            ViewData["Vdata"] = "İlçe : " + adres.Ilce;
            TempData["Tdata"] = "Açık Adres : " + adres.AcikAdres;
            return View(adres); // Eğer sayafa Model kullanarak veri gösterilecekse return View içerisinde model nesnesi gönderilmelidir!
        }
    }
}