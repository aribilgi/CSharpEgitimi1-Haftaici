using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11StructYapilar
{/*
     * C# dilinde yapılar(Struct) farklı veri tiplerinden oluşan bir karma yapıdır. Sınıflara benzerler, onlar gibi tanımlanır, nesneleri onlar gibi oluşturulur, alanlar(field), metotlar, numaratörleri içerebilirler.
     * Sınıfın nesneleri bellekte heap alanında tutulurken, yapı(struct) ın nesneleri stack alanında tutulur
     * C# dilinde değişkenler değer(value) ve referans tipler olmak üzere ikiye ayrılır, ana bellek içinde değer tipler stack alanında referans tipler heap alanında tutulur
     * String dışındaki tüm veri tipleri değer tiplidir ve stack de tutulur
     * Nesneler ve string veri tipli değişkenler referans tiplidir heap de tutulurlar
     * Stack de tutulan öğelerin işi bitince kendiliğinden bellekten silinirler
     * Referans tiplerin işi bitince çöp toplayıcı(garbage collector) onları toplayıp siler ve boşalan bellek bölgesini heap e katar.
     */
    struct Yapi
    {
        //public string ad = "ali";//struct kullanımında class dan farklı olarak öğelere başlangıç değeri atanamaz
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }
    public struct StatikDegiskenKullanimi
    {
        public static string isim = "Veli"; //struct kullanımında oluşturduğumuz değişkenlere başlangıç değeri vermek istiyorsak değişkenlere static niteliği eklememiz gerekiyor
        public static int yas = 18;
        struct Kimlik // StatikDegiskenKullanimi struct ının içine Kimlik isminde bir struct daha oluşturduk
        {
            //Kimlik struct'ının değişkenleri
            public string ad;
            public string soyad;
            public int yas;
            public string dogumyeri;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Yapi ilkyapi = new Yapi();
            ilkyapi.metin = "yapı metni";
            ilkyapi.sayi = 18;
            ilkyapi.Metot();
            Console.WriteLine(ilkyapi.metin);

            Console.WriteLine("StatikDegiskenKullanimi.isim : " + StatikDegiskenKullanimi.isim);
            Console.WriteLine("StatikDegiskenKullanimi.yas : " + StatikDegiskenKullanimi.yas);

            Console.ReadLine();
        }
    }
}
