using MvcWebApi.Entities;
using MvcWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        UrunDbContext context = new UrunDbContext();
        // GET: api/Products
        public IEnumerable<Product> Get() // Get metodu Products api controller a yapılan get isteklerine ürün listesini döndürerek cevap verir
        {
            return context.Products; // Geriye context üzerinden ürünleri döndür
        }

        // GET: api/Products/5
        public Product Get(int id) // Eğer api controller a api/Products/5 şeklinde id göndererek bir istek gelirse bu metot çalışır
        {
            return context.Products.Find(id); // ve geriye adres çubuğundan gelen id ye sahip ürünü find metoduyla bulup döndürür
        }

        // POST: api/Products
        [HttpPost]
        public IHttpActionResult Post(Product product)
        {
            if (!ModelState.IsValid) // Modelstate geçerli değilse
            {
                return BadRequest(); // Geriye bozuk istek hatası dön
            }
            context.Products.Add(product); // gelen ürünü contexte ekle
            context.SaveChanges(); // kaydı veritabanına işle

            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product); // Geriye işlem sonucunu ve eklenen ürün bilgisini döndür
        }
        /*
         * Postman ile ürün ekleme işlemi
         * Önce vs studioyu starta basarak çalıştır, api çalışmazsa istek başarısız olur!
         * Postman i aç ve sağ bölümden + butonu ile yeni sekme aç
         * Url kısmına tarayıcı adres çubuğundan ürün listesi adresini kopyala ve buraya yapıştır (https://localhost:44387/api/Products) Eğer SSL hatası verirse disable deuip uyarıyı kapat!
         * Postmanda adresi yazdığımız yerin solundan Metot olarak Post u seç
         * Adresin alt kısmından Body > Raw > JSON seçeneklerini seç ve Json formatında ilgili Product özelliklerini doldur.
         * Şu şekilde :
         * {   
                "UrunAdi": "Bardak",
                "UrunFiyati": 20.00,
                "StokMiktari": 25
            }
            Send butonuna bastığımızda eğer modelimiz geçerliyse yani tüm zorunlu alanları gönderdiysek geriye eklenen ürün bilgileri postmana gelecektir.
            Ayrıca eklenen ürünü veritabanından ve tarayıcıdaki ürün liste sayfasını yenileyerek görebiliriz artık.
         */

        // PUT: api/Products/5
        [HttpPut]
        public IHttpActionResult Put(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            context.Entry(product).State = System.Data.Entity.EntityState.Modified; // gelen ürünün bilgisini güncellenecek olarak entity frameworke bildir.
            try
            {
                context.SaveChanges(); // işlemi veritabanına kaydetmeyi dene
            }
            catch (Exception)
            {
                throw; // Eğer hata oluşursa hata fırlat
            }
            return StatusCode(HttpStatusCode.NoContent); // Eğer işlem başarılıysa geriye no content durum kodu dön
            // Güncelleme işleminde post işleminden farklı olarak Postman den güncellenecek ürünün Json bilgileri içerisinde Id değerini göndermeliyiz. Ayrıca istek yaparken Metot olarak Put u seçip adres çubuğunda da https://localhost:44387/api/Products/7002 şeklinde en sonda güncellenecek ürün id sini göndermeliyiz!
        }

        // DELETE: api/Products/5
        public IHttpActionResult Delete(int id)
        {
            Product product = context.Products.Find(id); // Gelen id ye ait ürünü db den bul
            if (product == null) // Eğer gelen id ye ait ürün yoksa
            {
                return NotFound(); // Geriye bulunamadı hatası döndür
            }
            context.Products.Remove(product); // Ürün bulunduysa context den sil
            context.SaveChanges(); // Silmeyi veritabanına işlet
            return Ok(product); // İşlem tamamlandıktan sonra geriye Ok-başarılı iletisi ile silinen ürün bilgisini dön
            // Api silme işleminde Postman den metot olarak Delete i seçiyoruz, adres çubuğuna https://localhost:44387/api/Products/6004 şeklinde id si ile url i yazıyoruz ve direk post butonuna basıyoruz. Bir hata yoksa bize alt kısımda silinen ürün bilgileri dönecektir.
        }
    }
}
