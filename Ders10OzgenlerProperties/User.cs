using System;

namespace Ders10OzgenlerProperties
{
    public class User
    {
        public int Id { get; set; }
        public int AdresId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        public bool KullaniciGiris(string mail, string sifre)
        {
            string veritabanindaKayitliMail = "info@uygulama.com";
            string veritabanindaKayitliSifre = "123456";
            bool islemSonucu = false;

            if (mail == veritabanindaKayitliMail && sifre == veritabanindaKayitliSifre)
            {
                islemSonucu = true;
            }

            return islemSonucu;
        }

    }
}
