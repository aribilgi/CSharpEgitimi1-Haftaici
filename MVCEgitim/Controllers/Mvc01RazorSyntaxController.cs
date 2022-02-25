using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class Mvc01RazorSyntaxController : Controller
    {
        // GET: Mvc01RazorSyntax
        public ActionResult Index()
        {
            // Mvc de controller oluşturmak için Solution explorer da controllers klasörüne sağ tık > açılan menüden Add > oradan en üstteki controller ı seçip Ok dedik > 1 pencere daha açıldı orada da Default olarak gelen ismi silip vermek istediğimiz ismi yazdık uzantısını ise controller olarak bıraktık
            return View(); // controller ı oluşturduğumuzda aynı isimle views klasörüne bir klasör ekleniyor ama içi boş olarak. Bu klasöre view ları kendimiz ekliyoruz.
            // Yeni view eklemek için Index yazısına sağ tıklayıp add view yöntemiyle view oluşturabiliyoruz
        }
    }
}