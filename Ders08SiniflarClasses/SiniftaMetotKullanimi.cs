using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08SiniflarClasses // program.cs ve SiniftaMetotKullanimi.cs sınıflarının namespace isimleri aynı(Ders08SiniflarClasses) olduğu için birbirlerini direk tanırlar, farklı olsaydı bizim tanıtmamız gerekirdi
{
    public class SiniftaMetotKullanimi
    {
        string mesaj = "";
        public SiniftaMetotKullanimi() //ctor yazıp klavyeden tab tab yaparak oluşturulabilir
        {
            //Burası kurucu metot
            mesaj = "Kurucu metot çalıştı \n";
            Console.WriteLine(mesaj);
        }
        public void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
        }
        public static void ToplamaYap(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        public static string StatikDegisken = "Sınıfta statik değişken kullanımı";
    }
}
