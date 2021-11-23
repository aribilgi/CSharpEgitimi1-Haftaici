using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders16InterfacesArayuzler
{
    //Arayüzler (Interfaces)
    /* Arayüz nedir?
     * C# dilinde arayüz soyut bir veri tipidir. Sınıfa benzer şekilde bildirilir ancak içerdiği öğelerin tanımı değil yalnızca imzaları vardır.
     ** Interface ler öğe olarak şunları içerebilir;
     * Özgen imzaları(properties)
     * Metot imzaları
     * Delegeler
     * Olaylar(events)
     * İndexçiler
     * *Arayüzler öğe olarak şunları içeremezler!
     * Alan-değişken(field)
     * Kurucu
     * Yokedici
     * -Arayüz asla içerdiği öğeleri tanımlamaz; öyle olmasının nedeni bir arayüz farklı sınıflar tarafından farklı amaçlarla kullanılabilir. Her sınıf kullandığı (implement) arayüzün öğelerini kendi amacına göre tanımlar.
     * 
     * Arayüzler için geçerli kurallar
     * 
     * Bir arayüzün erişim belirteci public tir
     * Bir arayüzün bütün öğelerinin erişim belirteci public tir
     * Bir arayüz bir yapı(struct) dan veya bir sınıf(class) tan kalıtımla türetilemez
     * Bir arayüz başka bir arayüzden veya başka arayüzlerden kalıtımsal olarak türetilebilir
     * Arayüz öğeleri static nitelemesini alamaz
     * Arayüzü kullanan bir sınıf arayüzün bütün öğelerinin açık tanımlarını vermek zorundadır
     * Arayüzü kullanan sınıfta arayüzün bütün öğeleri public erişim belirtecini alır
     * arayüz, nesnelere erişimi standart biçime sokar, nesnenin iç yapısını bilmeden nesneyi kullanma imkanı sunar
     */
    interface OrnekArayuz //Örnek arayüz oluşturma
    {
        int Id { get; set; }
    }
    interface Idemo
    {
        //Arayüz tanımlaması interface ifadesi ile yapılır ve yapacağı işleme göre I harfiyle başlayan bir isim verilir
        void Goster();//Interface lerde sadece metot imzaları yer alır, metotlar bu interface den miras alan class larda kullanılır
    }
    interface icerebilecekleri : Idemo//Bir interface in içerebileceği özellikler
    {
        //public int sayi1 { get; set; } //bir interface içerisine prop tab tab ile property eklersek başındaki public ifadesini kaldırmak zorundayız çünkü interfaceler erişim belirteci almaz daima public tir zaten
        int sayi { get; set; }
        //static int sayi { get; set; } interfacelerde bu şekilde static kullanılamaz
        //void Goster();//interface ler metot imzalarını barındırabilir
        int ToplamaYap();//metot imzalarında da public vb erişim belirteci kullanılmaz
        //İçeremedikleri
        //string metin; //interfaceler içerisinde değişken kullanılamaz
        //interfaceler class lardaki kurucu metotları da kullanamaz
        /*int CikarmaYap()
        {
            int sayi1 = 5; int sayi2 = 10; interfacelerde metotların yapacağı iş bu şekilde tanımlanamaz, hata verir, metotların sadece adı tanımlanır ne iş yapacağı kullanılacağı yere bırakılır
            return sayi2 - sayi1;
        }*/
    }

    class arayuzKullanimi : icerebilecekleri
    {
        public int sayi { get; set; }

        public void Goster()
        {
            Console.WriteLine("arayuzKullanimi sınıfı içerisindeki goster metodu çalıştı");
        }

        public int ToplamaYap()
        {
            return 10 + 8;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            arayuzKullanimi arayuz = new arayuzKullanimi();
            arayuz.sayi = 18;
            arayuz.Goster();

            Urun urun = new Urun()
            {
                CreateDate = DateTime.Now,
                ChangeDate = DateTime.Now,
                Name = "Cep Telefonu",
                Price = 9999
            };
            urun.Add();


            Console.Read();
        }
    }

    interface ISinifGereksinimleri
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ChangeDate { get; set; }
        string User { get; set; }
    }
    interface VeritabaniIslemleri
    {
        void Add();
        void Update();
        void Delete();
        void Get();
        void GetAll();
    }
    class Kategori : ISinifGereksinimleri, VeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string User { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Urun : ISinifGereksinimleri, VeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string User { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public void Add()
        {
            Console.WriteLine(Name + " Ürünü Eklendi!");
        }

        public void Delete()
        {
            //ürün silme komutları
            Console.WriteLine("Ürün Silindi!");
        }

        public void Get()
        {
            Console.WriteLine("Ürün Getirildi!");
        }

        public void GetAll()
        {
            Console.WriteLine("Ürünler Listelendi!");
        }

        public void Update()
        {
            Console.WriteLine("Ürün Güncellendi!");
        }
    }
    class Marka : ISinifGereksinimleri, VeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string User { get; set; }
        public string Logo { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
