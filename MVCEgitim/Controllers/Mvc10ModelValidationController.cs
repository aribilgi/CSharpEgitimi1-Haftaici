using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc10ModelValidationController : Controller
    {
        // GET: Mvc10ModelValidation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid) // Eğer sayfa modeli geçerliyse aşağıdaki işlemleri yap
            {
                ViewBag.Uyebilgi = $"Üye Adı : {uye.Ad} <hr />Üye Soyad : {uye.Soyad} <hr />Üye Email : {uye.Email} <hr />Üye TCKimlikNo : {uye.TCKimlikNo} <hr />";
            }
            return View();
        }
        public ActionResult UyeDuzenle()
        {
            Uye uye = new Uye()
            {
                Id = 18,
                Ad = "Fatih",
                Soyad = "Sultan",
                Email = "fatih@sultan.net",
                TCKimlikNo = "0001453"
            };
            return View(uye);
        }
        [HttpPost]
        public ActionResult UyeDuzenle(Uye uye)
        {
            if (ModelState.IsValid)
            {
                // veritabanı güncelleme işlemi burada yapılır
            }
            return View(uye); // yukarıdan gelen uye nesnesi tekrar ekrana gönderilir
        }
        public ActionResult UyeListesi()
        {
            var uyelistesi = new List<Uye>() {
                new Uye(){ Id = 18, Ad = "Fatih", Soyad = "Sultan", Email = "fatih@sultan.net", TCKimlikNo = "0000001453" },
                new Uye(){ Id = 25, Ad = "Murat", Soyad = "Yılmaz", Email = "murat@yilmaz.co", TCKimlikNo = "0000012534" }
            };
            return View(uyelistesi);
        }
        public ActionResult UyeSil()
        {
            Uye uye = new Uye()
            {
                Id = 18,
                Ad = "Fatih",
                Soyad = "Sultan",
                Email = "fatih@sultan.net",
                TCKimlikNo = "0001453"
            };
            return View(uye);
        }
        [HttpPost]
        public ActionResult UyeSil(Uye uye)
        {
            // burada üye db den silinir
            return View(uye);
        }
    }
}