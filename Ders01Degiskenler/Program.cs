using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders01Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Heap, Stack
            //C# ta 2 tipte yapı vardır 
            //1-Değer Tipleri (Stack te tutulur)
            //2-Referans Tipleri (Belleğin heap bölgesinde tutulur, sınıflara ait tüm nesneler burada tutulur)

            //C# ta değişken tanımlama
            //Tamsayı veri tipleri
            byte plaka_kodu; //değişken oluşturma, byte 0 - 255 arası tam sayı değer alır
            plaka_kodu = 34; //oluşan değişkene değer atama
            sbyte sbyteveri = 127; //+127 - 128 arası değer alır
            short kisatamsayi = 1971;
            ushort ortamsayi = 65535;
            int tamSayi = 2021;
            uint uzunTamsayi = 456789;
            long uzuuntamsayi = 987654321;
            ulong enuzuntamsayi = 12365478963;

            //Kesirli sayı değişken tipleri
            float kesirliSayi1 = 34.18f; //float veri tipinde sayının sonuna f harfi eklenir. 4 byte yer kaplar, 6-7 basamak sayı alabilir
            double kesirliSayi2 = 34.18; //8 byte yer kaplar, 15-16 basamak sayı alabilir

            //Decimal veri tipi
            decimal urunFiyati = 9999; //12 byte 28-29 basamağa kadar destekler

            //Char veri tipi
            char karakter = 'k'; // Sadece 1 karakter veri alabilir

            //String veri tipi
            string metin = "string veri tipinde klavyedeki tüm karakterleri kullanabiliriz";

            //Boolean veri türü
            bool urunDurumu = true; //bool 2 değer alır true veya false, 1 byte lık yer kaplar

            metin = "değişken değeri değişebilir";

            //C# ta sabit tanımlama
            const int kdv = 18; // veri tipinden önce const ifadesini yazarak sabit değerler tanımlayabilriz
            const int iskonto = 20; //sabitlerin başlangıç esnasında değer ataması yapılır
            //kdv = 8;//bir sabitin değeri sonradan değiştirilemez!

            Console.WriteLine(metin);
            Console.ReadLine();
        }
    }
}
