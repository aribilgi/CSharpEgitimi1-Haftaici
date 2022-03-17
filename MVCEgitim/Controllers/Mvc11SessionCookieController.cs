using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc11SessionCookieController : Controller
    {
        // GET: Mvc11SessionCookie
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text)
        {
            // Session'a deger atama..
            Session["deger"] = text;
            //Session.Add("deger", text); // Sessiona değer atamanın 2. yöntemi

            return RedirectToAction("Sessions");
        }
        public ActionResult Sessions()
        {
            if (Session["deger"] != null)
            {
                ViewBag.SessDeger = Session["deger"].ToString();
            }
            else
            {
                ViewBag.SessDeger = "Sessionda veri yok!";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Sessions(string text)
        {
            if (Session["deger"] != null)
            {
                //Session["deger"] = null; // 1. session silme yöntemi
                Session.Remove("deger"); // 2. session silme yöntemi
            }
            else
            {
                ViewBag.SessDeger = "Sessionda veri yok!";
            }
            return View();
        }
        public ActionResult CookieOku()
        {
            if (HttpContext.Request.Cookies["kullanici"] == null)
                ViewBag.Kullanici = "Cookie Yok";
            else
                ViewBag.Kullanici = "Cookie Değeri : " + HttpContext.Request.Cookies["kullanici"].Value; //Cookie nin değerini okuyup ViewBag e atadık
            return View();
        }
        [HttpPost]
        public ActionResult CookieOlustur(string kuki)
        {
            HttpCookie cookieKullanici = new HttpCookie("kullanici", kuki); //Cookie oluşturma
            HttpContext.Response.Cookies.Add(cookieKullanici); //Cookie yi istemciye yerleştirme
            return RedirectToAction("CookieOku"); // sayfayı CookieOku sayfasına yönlendirme
        }
        [HttpPost]
        public ActionResult CookieSil()
        {
            if (HttpContext.Request.Cookies["kullanici"] != null)
                HttpContext.Response.Cookies["kullanici"].Expires = DateTime.Now.AddSeconds(-3);
            else ViewBag.Message = "Cookie Yok";

            return RedirectToAction("CookieOku");
        }
    }
}