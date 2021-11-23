using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10OzgenlerProperties
{
    class Skorlar
    {
        private int skor;
        public int Skor //Örnek özgen yapısı
        {
            get { return skor; } //get bloğu geriye yukarıdaki skor değişkeninin değerini döndürür
            set { skor = value; } // set bloğu ise yukarıdaki skor değişkenine değer atamayı sağlar
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Skorlar skorlar = new Skorlar();
            skorlar.Skor = 5; //burada set bloğu çalışır

            Console.WriteLine("Skor değeri : " + skorlar.Skor); //skorlar.Skor ile değer okumaya kalkarsak get bloğu çalışır

            Kisi Aylin = new Kisi();
            Kisi Gizem = new Kisi();

            Aylin.DogumYeri = "Bodrum";
            Aylin.Yas = 25;
            Aylin.Maas = 3750;
            Gizem.DogumYeri = "Kuşadası";
            Gizem.Yas = 26;
            Gizem.Maas = -3000;

            Console.WriteLine("Aylin bilgiler ; Doğum yeri :" + Aylin.DogumYeri + ", Yaş = " + Aylin.Yas + ", Maaş : " + Aylin.Maas);
            Console.WriteLine($"Gizem bilgiler; Doğum yeri :{Gizem.DogumYeri}, Yaş = {Gizem.Yas}, Maaş: {Gizem.Maas}");

            User user = new User();
            user.Adi = "Ali"; // bu şekilde user ın property lerine değer gönderirsek set bloğu çalışır
            user.Soyadi = "Pusat";
            //user.Email = "info@uygulama.com";
            //user.Sifre = "123456";

            Console.WriteLine("Kullanıcı bilgileriniz : ");
            Console.WriteLine($"Adınız : {user.Adi} Soyadınız : {user.Soyadi}");
            Console.WriteLine("E mail Adresinizi Giriniz:");
            user.Email = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz");
            user.Sifre = Console.ReadLine();
            var giris = user.KullaniciGiris(user.Email, user.Sifre);
            if (giris) //burada giris değişkeninden true veya false döneceği için if (giris == true) ile aynı anlama gelir
            {
                Console.WriteLine("Sisteme giriş başarılı");
            }
            else Console.WriteLine("Giriş Başarısız!");
            Console.ReadLine();
        }
    }
}
