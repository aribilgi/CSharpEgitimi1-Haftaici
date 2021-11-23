using Ders08SiniflarClasses;
using System;

namespace Ders09ErisimBelirleyiciler
{
    /*C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır.
     sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
     Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri" (acces modifiers) denir.
     *Erişim belirteçleri 4 ana sınıfa ayrılır
     * public    : Erişim kısıtı yoktur, her yerden erişilebilir
     * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
     * internal  : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
     * private   : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
     * Bir öğe yalnızca 1 erişim belirteci alabilir
     * namespace erişim belirteci almaz çünkü o daima public tir
     * Sınıflar public yada internal nitelemesi alabilirler ama protected yada private nitelemesi alamazlar
     * enum erişim belirteci almaz çünkü daima public tir
     */
    public class deneme
    {
        public string urunAdi = "public öğeye herkes erişebilir";
    }
    internal class test
    {
        string urunAdi;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Adi = "Admin";
            kullanici.Soyadi = "User";

            Console.WriteLine($"Kullanıcı bilgileriniz; {kullanici.Adi}, {kullanici.Soyadi}");

            SiniftaMetotKullanimi siniftaMetotKullanimi = new SiniftaMetotKullanimi();

            siniftaMetotKullanimi.ToplamaYap();
            
            Console.Read();
        }
    }
}
