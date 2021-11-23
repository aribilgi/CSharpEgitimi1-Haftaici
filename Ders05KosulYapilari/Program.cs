using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders05KosulYapilari
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int sayi = 0;

            if (sayi > 0)//eğer sayı 0 dan büyükse
            {
                // burası işletilir.
                Console.WriteLine("sayı pozitif");
            }
            else if (sayi == 0)//yukardaki değilse eğer sayı 0 a eşitse
            {
                // burası işletilir
                Console.WriteLine("sayı sıfırdır");
            }
            else//yukardakilerin hiçbiri değilse
            {
                //sayı 0 dan küçükse işletilir.
                Console.WriteLine("sayı negatif");
            }

            
            
            */

            //Örnek 2
            /*
            Console.WriteLine("Kullanıcı Adınızı Giriniz");
            string kullaniciadi = Console.ReadLine();//Console.ReadLine() metodu ekrandan girilen değeri yakalar ve kullaniciadi değişkenine atar
            Console.WriteLine("Şifrenizi Giriniz");
            string sifre = Console.ReadLine();//Console.ReadLine() metodu ekrandan girilen değeri yakalar ve sifre değişkenine atar

            string veritabanindakiKullaniciAdi = "admin";
            string veritabanindakiSifre = "123456";

            if (kullaniciadi == veritabanindakiKullaniciAdi && sifre == veritabanindakiSifre)//Eğer ekrandan girilen kullanıcı adı ve şifre veritabanımızdaki ile eşleşiyorsa
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifrenizde hata var!");
            }
            
            */



            //Örnek 3
            /*
            Console.WriteLine("Yaşınızı Giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());//Console.ReadLine() metodu ekrandan aldığı veriyi string veri tipinde bize döndürür, convert metoduyla sayısal string veriyi int e çevirebiliriz
            Console.WriteLine("Öğrenim Durumuz (ilkokul,ortaokul,lise,üniversite)");
            string ogrenim = Console.ReadLine();//"lise";

            if (yas >= 18)
            {
                if (ogrenim == "lise" || ogrenim == "üniversite") Console.WriteLine("Ehliyet alabilirsiniz.");
                else Console.WriteLine("Öğrenim durumunuz ehliyet için yeterli değil");
            }
            else Console.WriteLine("Ehliyet için yaşınız tutmuyor");
            //koşul yapılarında tek satırlık kod yazacaksak küme parantezine almamıza gerek yok fakat şart bloğu içerisinde birden fazla satır kod yer alacaksa küme parantezi kullanmak zorundayız
            */

            
            //Örnek4

            /*
            int saat = DateTime.Now.Hour;
            if (saat < 18)
            {
                Console.WriteLine("Saat : " + saat + " İyi günler");
            }
            else Console.WriteLine("Saat : " + saat + " İyi Akşamlar");            

            Console.WriteLine("//Ternary operatörü ile if else yazmadan if else i kullanabiliriz");

            Console.WriteLine((saat < 18) ? "İyi günler" : "İyi Akşamlar");//(saat < 18) ? kısmı şart kısmı, ? işaretinden sonraki kısım if, : işaretinden sonraki kısım else anlamına gelir
            
             */
            


            Console.WriteLine("1 ile 12 arasında bir sayı giriniz :");
            /**/
             
            int ay = DateTime.Now.Month;//Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    break;
                default:
                    Console.WriteLine("Yanlış bilgi.");
                    break;
            }
            
            Console.Read();
        }



    }
}
