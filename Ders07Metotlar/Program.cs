using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders07Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            //ToplamaYap();

            //ToplamaYap2();

            //ToplamaYap(25, 18);//parametre alan metoda parametreleri gönderme bu şekilde

            /*Console.WriteLine("Mail adresinizi giriniz :");
            var mail = Console.ReadLine();
            
            var sonuc = MailGonder(mail);
            if (sonuc == true)
            {
                Console.WriteLine(mail + " adresinde mail gönderimi başarılı!");
            }
            else
            {
                Console.WriteLine(mail + " adresinde mail gönderimi başarısız!");
            }

            var sonuc2 = MailGonder2(mail);
            if (sonuc2 == "Başarılı")
            {
                Console.WriteLine(mail + " adresinde mail gönderimi başarılı!");
            }
            else
            {
                Console.WriteLine(mail + " adresinde mail gönderimi başarısız!");
            }
*/
            Console.WriteLine("Bir Cümle yazıp enter a basınız");
            string cumle = Console.ReadLine();
            Console.WriteLine("Cümledeki küçük harf sayısı {0} adettir.", KucukHarfSay(cumle));

            Console.Read();
        }

        static void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
        }
        static void ToplamaYap2()
        {
            Console.WriteLine(18 + 18);
        }
        static void ToplamaYap(int sayi1, int sayi2)//metotların parametre ile kullanımı
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        static bool MailGonder(string mailAdresi)
        {
            string sistemdekiMailAdresi = "info@bilgi.co";
            if (mailAdresi == sistemdekiMailAdresi)
            {
                //Burada mail gönderim kodları olacak
                return true;
            }
            else return false;
        }
        static string MailGonder2(string mailAdresi)
        {
            string sistemdekiMailAdresi = "info@bilgi.co";
            if (mailAdresi == sistemdekiMailAdresi)
            {
                //Burada mail gönderim kodları olacak
                return "Başarılı";
            }
            else return "Başarısız";
        }
        static int KucukHarfSay(string kucukHarfiSayilacakMetin)
        {
            int kucukharfsayisi = 0;//sayacağımız küçük harf sayısını tutmak için değişkenimiz
            foreach (char harf in kucukHarfiSayilacakMetin)
            {
                if (char.IsLower(harf)) kucukharfsayisi++;//Eğer ekrandan okunan metin içerisindeki harf küçükse kucukharfsayisi değerini 1 artır
            }
            return kucukharfsayisi;//geriye döndürülen değer
        }
    }
}
