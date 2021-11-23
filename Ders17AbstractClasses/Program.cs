using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders17AbstractClasses
{
    /*
     * Abstract sınıflar içerisinde hem metot tanımlayabilir hem de arayüzler de olduğu gibi metot bildirimi yapabiliriz.
     
    Abstract Sınıfların Normal Sınıflardan Farkı Nedir?
 1: Normal sınıflar içerisinde metot bildirimi yapılamazken, Abstract sınıflar içerisinde tıpkı arayüzler de olduğu gibi metot bildirimi yapılabilir. Bildirimi yapılan metotlar, Abstract sınıftan türeyen sınıflar içerisinde tanımlanmak zorundadır.

 2: Normal sınıflardan “new()” anahtar sözcüğü ile nesneler oluşturulabilir ancak Abstract sınıflar tamamen kalıtım amaçlı geliştirildiğinden Abstract sınıflardan nesne oluşturulamaz.

    Abstract Sınıfların Arayüzlerden Farkı Nedir?
 1: Arayüzlerde sadece metot bildirimi yapılabilirken Abstract sınıflarda hem metot bildirimi yapılabilir hem de metot tanımlanabilir.

 2: Bir sınıfa sadece bir tane Abstract sınıf inherit edilebilir ancak aynı sınıfa birden fazla arayüz implement edilebilir.

    Kullanırken dikkat edilmesi gerekenler:

•    Soyut sınıflar “abstract” türünden nesneler tanımlamazlar.
•    Soyut sınıflar içerilerinde soyut olmayan metotlar da barındırabilir ancak soyut metotlar sadece soyut sınıflar içerisinde bildirilebilir.
•    Soyut metotlar türeyen sınıfta mutlaka bildirilmelidir.
•    Soyut metotlar override edilmek zorundadırlar, aksi takdirde derleyici hatası alınır.
•    “Static” metotlar soyut olarak tanımlanamazlar.
•    Soyut sınıflar “private” olarak tanımlanamazlar ama “public” ve “protected” olarak tanımlanabilirler.
•    Soyut sınıflar “sealed” anahtar sözcüğü ile ifade edilemezler.  

    */
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();//Database sınıfından yeni bir oracle nesnesi oluşturuyoruz
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();//Database sınıfından yeni bir SqlServer nesnesi oluşturuyoruz
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Add metodu çalıştı Ekleme yapıldı");
        }

        public abstract void Delete();//crud
        public abstract void Update();//crud
        public abstract void Get();//crud
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Sql den silindi");
        }

        public override void Get()
        {
            Console.WriteLine("Sql den kayıt getirildi");
        }

        public override void Update()
        {
            Console.WriteLine("Sql deki kayıt güncellendi");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle den silindi");
        }

        public override void Get()
        {
            Console.WriteLine("Oracle den kayıt getirildi");
        }

        public override void Update()
        {
            Console.WriteLine("Oracle deki kayıt güncellendi");
        }
    }

    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("MySql dan silindi");
        }

        public override void Get()
        {
            Console.WriteLine("MySql den kayıt getirildi");
        }

        public override void Update()
        {
            Console.WriteLine("MySql deki kayıt güncellendi");
        }
    }

}
