using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEgitim.Models
{
    public class Uye
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string TCKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string KullaniciAdi { get; set; }
    }
}