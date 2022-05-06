using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApi.Controllers
{
    public class ValuesController : ApiController // BU controller controller class ı yerine ApiController classından miras alır böyece normal controller dan ayrılıp api özellikleri taşımaya başlar
    {
        // GET api/values : adres çubuğunda proje isminden sonra api/values yazılırsa api çalışır
        public IEnumerable<string> Get() // Get metodu ile string listesi döndürüyor
        {
            return new string[] { "Klavye", "Monitör", "Mouse", "Kasa", "Kulaklık" }; // Geriye string dizisi döner
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Mikrofon";
        }

        // POST api/values
        public void Post([FromBody] string value) // Post metodu db ye kayıt eklemek için
        {
            // Burada api ye gelen post isteği sonucu db ye kayıt eklenir
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            // Gelen Put isteği ile db deki kayıt burada güncellenir
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            // Gelen delete isteği ile id ile eşleşen kayıt db den silinir
        }
    }
}
