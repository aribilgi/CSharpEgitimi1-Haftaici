using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders06Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Döngü kullanmadan ekrana sayı yazdırma
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            

            Console.WriteLine("For Döngüsü");
            int toplam = 0;
            for (int i = 0; i < 10; i++)//i değişkeni oluştur ve 0 değerini ata; i 10 dan küçük olduğu sürece dön; her dönüşte i yi 1 artır i++ ile
            {
                toplam += i;
                Console.WriteLine("i değişkeninin değeri {0} toplamın değeri {1}", i, toplam);
            }
            Console.WriteLine("Toplam : " + toplam);

            

            Console.WriteLine("While Döngüsü");
            int i = 0;
            while (i < 5) //While döngüsünün şartı bu şekilde, anlamı toplam küçükse 5 den sürekli dön
            {
                Console.WriteLine("While Sayı {0}", i);//toplamın değerini ekrana yazdırıyoruz
                i++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }

            Console.WriteLine("Do While Döngüsü");
            int toplam = 0;
            do
            {
                //Console.WriteLine("Veritabanına bağlan");
                //Console.WriteLine("Verileri Çek");
                Console.WriteLine("Do while Sayı {0}", toplam);//toplamın değerini ekrana yazdırıyoruz
                toplam++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program
            }
            while (toplam < 10); //Do While döngüsünün şartı bu şekilde, anlamı toplam küçükse 10 dan sürekli dön
            
             
            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep Telefonu", "Beyaz Eşya", "Kitap" };
            int[] ogrenciler2 = { 100, 200, 300 };

            Console.WriteLine("Foreach Döngüsü");

            var degisken = "18"; //var ile değişken tanımlama işlemi yapılır. var ile oluşturulan değişkenlerin veri tipi(int,double,string vb) değişkene atanan değere göre c# tarafından otomatik olarak algılanır

            foreach (var item in kategoriler)
            {
                Console.WriteLine("Kategori Adı : " + item);
            }

            foreach (var ogrenciNo in ogrenciler2)
            {
                Console.WriteLine("Öğrenci Numarası : " + ogrenciNo);
            }
            

            Console.WriteLine("İç İçe Foreach Döngüsü");

            string[] urunler = { "Klavye","Mouse","Monitör" };

            foreach (var isim in kategoriler)
            {
                Console.WriteLine("Kategori Adı : " + isim);
                foreach (var urun in urunler)
                {
                    Console.WriteLine("     Ürün Adı : " + urun);
                }
            }
*/
            Console.WriteLine("İç İçe For Döngüsü");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i değişkeninin değeri {0}", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\t j değişkeninin değeri {0} dır", j);
                }
            }

            Console.ReadLine();
        }
    }
}
