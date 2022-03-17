using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc12FileUploadController : Controller
    {
        // GET: Mvc12FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase dosya) // Mvc de resim yükleme işlemi HttpPostedFileBase sınıfı kullanılarak yapılıyor. Dikkat !! dosya yazan isim ön yüzdeki file upload ın name alanı ile eşleşmeli yoksa resim yüklenmez!
        {
            if (dosya != null && dosya.ContentLength > 0)
            {
                var extensition = Path.GetExtension(dosya.FileName); // dosya uzantsını al

                if (extensition == ".jpg" || extensition == ".png") // uzantıyı kontrol et
                {
                    //1. yöntem rasgele resim adı oluşturarak yükleme
                    //var folder = Server.MapPath("~/Images"); // resmin yükleneceği klasör
                    //var randomfilename = Path.GetRandomFileName(); // rasgele dosya adı oluşturduk
                    //var filename = Path.ChangeExtension(randomfilename, ".jpg");
                    //var path = Path.Combine(folder, filename); // klasör ve resim adını birleştirdik

                    //2. yöntem yüklenen resim adı ile yükleme
                    var filename = Path.GetFileName(dosya.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images"), filename);

                    dosya.SaveAs(path); // Resmi sunucuya farklı kaydet yöntemiyle yükledik

                    ViewBag.Resimadi = filename;
                }
                else ViewData["message"] = "Sadece .jpg ve .png resimleri yükleyebilirsiniz!";
            }
            else
            {
                ViewData["message"] = "Bir dosya seçiniz";
            }
            return View();
        }
    }
}