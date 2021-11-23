using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Ders18CollectionsKoleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ornek1();
            //Ornek2();
            //Ornek3();
            //Ornek4();
            //Ornek5();
            //Ornek6();
            //Ornek7();
            //Ornek8();
            //HashTableMethod();
            //Ornek9();
            ListKullanimi();
            Console.Read();
        }

        static void Ornek1()
        {
            ArrayList birDizi = new ArrayList();//Koleksiyonları kullanmak için System.Collections kütüphanesini using  kısmına eklememiz gerekiyor. ArrayList sınıf objelerinden oluşan array oluşturur.
            birDizi.Add(12);//Koleksiyona veri eklemek için Add() metodu kullanılıyor
            birDizi.Add(3);
            birDizi.Add(8);
            foreach (int n in birDizi)//Koleksiyondaki verileri ekrana yazmak için foreach döngüsü kullanıyoruz
            {
                Console.WriteLine(n);//Koleksiyon içindeki verileri döngüde tanımladığımız n değişkenine atayıp her dönüşte değerini ekrana yazdırıyoruz
            }
            Console.WriteLine(birDizi[0]);
            //Ekranın kapanmaması için
        }
        static void Ornek2()
        {
            ArrayList birDizi = new ArrayList();//birDizi isminde bir koleksiyon oluşturduk
            birDizi.Add("Zonguldak");//Koleksiyona veriler atadık
            birDizi.Add("Sinop");
            birDizi.Add("Çankırı");
            birDizi.Add("Ankara");
            birDizi.Add("İstanbul");
            Console.WriteLine("Sıralanmamış Liste");
            foreach (var sehir in birDizi)
            {
                Console.WriteLine(sehir);//Koleksiyondaki verileri varsayılan haliyle ekrana yazdırdık
            }
            Console.WriteLine();

            Console.WriteLine("A dan Z ye Sıralanmış Liste");
            birDizi.Sort(); //Koleksiyondaki verileri Sort ile A dan Z ye sıraladık.
            foreach (var sehir in birDizi)
            {
                Console.WriteLine(sehir);//Koleksiyondaki verileri sıralanmış haliyle ekrana yazdırdık

            }
            Console.WriteLine();
            birDizi.Reverse(); //Koleksiyondaki verileri Reverse ile Z den A ya sıraladık.
            foreach (var item in birDizi)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
        class Diziler
        {
            public static void DiziYap(ArrayList arr)//DiziYap isminde koleksiyon oluşturucu bir metot yazdık
            {
                for (int k = 1; k <= 10; k++) arr.Add(k);//arr koleksiyonuna içerik ekledik
            }
            public static void DiziYaz(ArrayList arr)//DiziYaz isminde içerisine parametre olarak Arraylist alan metod oluşturduk
            {
                foreach (int n in arr) Console.WriteLine(n);//DiziYaz metodumuzun parametre olarak aldığı diziyi ekrana yazdırdık
            }
        }
        static void Ornek3()
        {
            ArrayList birDizi = new ArrayList();//birDizi isminde bir collections oluşturduk
            Diziler.DiziYap(birDizi);//Diziler sınıfımızın içerisindeki DiziYap metoduna birDizi koleksiyonunu gönderdik dizinin içeriğinin oluşturulmasını sağladık
            Diziler.DiziYaz(birDizi);//Diziler sınıfımızın içerisindeki DiziYaz metoduna birDizi koleksiyonunu gönderdik ve daha önce oluşturduğumuz dizideki verileri ekrana yazdırdık metot ile
            birDizi.Remove(7);//Koleksiyondan istediğimiz sıradaki veriyi silmek için remove metoduna numara verilir
            Diziler.DiziYaz(birDizi);//Koleksiyonu ekrana tekrar yazdırdığımızda artık silinen satır ekranda görünmez
        }
        static void Ornek4()
        {
            //Koleksiyonlara farklı veri tiplerinden değerler atama
            int tamsayi = 10;
            double dabil = 18.8;
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Başkent Angara");
            koleksiyon.Add(tamsayi);
            koleksiyon.Add(dabil);
            for (int index = 0; index < koleksiyon.Count; index++)
            {
                Console.WriteLine(koleksiyon[index]);
            }
        }
        static void Ornek5()
        {
            StringCollection strlist = new StringCollection();//string içeriklerden oluşacak koleksiyonlara özel StringCollection sınıfını kullanabiliriz
            strlist.Add("Çankırı");
            strlist.Add("Sinop");
            strlist.Add("Angara");
            strlist.Add("İstanbul");
            strlist.Add("Adana Merkez");
            foreach (var item in strlist)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek6()
        {
            StringDictionary strlist = new StringDictionary();//string içeriklerden oluşacak koleksiyonlara özel StringDictionary sınıfını kullanabiliriz böylece verilere key ve value değerleri atanabilir
            strlist.Add("18", "Çankırı");
            strlist.Add("57", "Sinop");
            strlist.Add("06", "Angara");
            strlist.Add("34", "İstanbul");
            strlist.Add("01", "Adana");
            strlist.Add("58", "Sivas");
            Console.WriteLine(strlist["06"]);

            foreach (var item in strlist.Values)
            {
                Console.WriteLine(item);
            }
            foreach (var item in strlist.Keys)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek7()
        {
            //Stack sınıfı programlamada LIFO (last in first out) son giren ilk çıkar diye bilinen önemli bir yapıdır
            Stack stekobje = new Stack();
            stekobje.Push("Çankırı");//Stack e bir öğe eklemek için push metodu kullanılır
            stekobje.Push("İstanbul");
            stekobje.Push("Angara");
            stekobje.Push("Sivas");
            stekobje.Push("Balıkesir");

            while (stekobje.Count > 0)
            {
                Console.WriteLine(stekobje.Pop());//Stack in üstünden bir öğe çekmek için pop metodu kullanılır
            }
        }
        static void Ornek8()
        {
            Queue queue = new Queue();//Queue sınıfı programlamada FIFO(First in first out, ilk giren ilk çıkar) diye bilinen bir yapısıdır.
            queue.Enqueue("Lale");
            queue.Enqueue("Gül");
            queue.Enqueue("Sümbül");
            queue.Enqueue("Menekşe");
            queue.Enqueue("Çiğdem");
            while (queue.Count > 0) Console.WriteLine(queue.Dequeue());
        }
        static void HashTableMethod()
        {
            //HashTable sınıfı object tiplerin hızla depolanması ve depodan hızla çekilmesi için kullanılan bir yöntemdir
            Hashtable hst = new Hashtable();
            hst.Add(1, "Adana");
            hst.Add(2, "Adıyaman");
            hst.Add(3, "Ayfon");
            hst.Add(4, "İztanbul");
            hst.Add(5, "Amasya");
            hst.Add(6, "Angara");
            Console.WriteLine("Anahtarlar : ");
            foreach (var item in hst.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Aramak İçin Anahtar Girin : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(hst[n]);
        }
        static void Ornek9()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");
            dictionary.Add("laptop", "dizüstü");
            dictionary.Add("tv", "televizyon");

            Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            Dictionary<int, string> keyValues = new Dictionary<int, string>();
            keyValues.Add(1, "Adana");
            keyValues.Add(5, "Amasya");
            keyValues.Add(6, "Ankara");
            keyValues.Add(18, "Çankırı");
            keyValues.Add(34, "İstanbul");

            Console.WriteLine(keyValues[18]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("gozluk"));
            Console.WriteLine(dictionary.ContainsKey("table"));
        }
        class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        static void ListKullanimi()
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Adana");
            sehirler.Add("İzmir");
            sehirler.Add("Çankırı");

            Console.WriteLine(sehirler.Contains("Adana"));

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine();

            List<User> users = new List<User>();
            users.Add(new User { Id = 1, FirstName = "Mesut" });
            users.Add(new User { Id = 2, FirstName = "Mahmut" });

            List<User> kullanicilar = new List<User>
            {
                new User {Id = 1, FirstName = "Murat"},
                new User {Id = 2, FirstName = "Ömer"}
            };

            var yeniKullanici = new User
            {
                Id = 3,
                FirstName = "Pusat"
            };
            Console.WriteLine(kullanicilar.Contains(yeniKullanici));
            kullanicilar.Add(yeniKullanici);

            kullanicilar.AddRange(new User[2]
            {
                new User {Id = 4, FirstName = "Murat", LastName = "Ilıca"},
                new User {Id = 5, FirstName = "Kadir", LastName = "Bektaş"}
            });
            kullanicilar.AddRange(users);
            Console.WriteLine(kullanicilar.Contains(yeniKullanici));//kullanicilar listesinde yeniKullanici var mı yok mu bunu contains metoduyla kontrol ettik, varsa geriye true yoksa false döner

            //users.Clear(); users listesini temizler
            Console.WriteLine();
            var index = kullanicilar.IndexOf(yeniKullanici);//kullanicilar listesinde yeniKullanici nesnesinin kaçıncı sırada(index olarak) geçtiğini yakalayıp index değişkenine atadık
            Console.WriteLine("Index : {0}", index);

            kullanicilar.Add(yeniKullanici);//kullanicilar listesinin sonuna yeniKullanici nesnesini ekle

            Console.WriteLine();
            var index2 = kullanicilar.LastIndexOf(yeniKullanici);//kullanicilar listesinde yeniKullanici nesnesi en son kaçıncı indexte geçiyor bunu bulup index2 değişkenine bu değeri atadık
            Console.WriteLine("Index2 : {0}", index2);

            kullanicilar.Insert(2, yeniKullanici);//kullanicilar listesinin 2 numaralı indexine(yani 3. eleman olarak) yeniKullanici nesnesini ekle

            Console.WriteLine();

            kullanicilar.Remove(yeniKullanici); //kullanicilar listesinden yeniKullanici nesnesini sil
            kullanicilar.RemoveAll(c => c.FirstName == "Mesut"); //kullanicilar listesinden FirstName değeri Mesut a eşit olanları sil

            foreach (var user in kullanicilar)
            {
                Console.WriteLine(user.FirstName);
            }

            var count = kullanicilar.Count;//kullanicilar listesinde kaç eleman var onu sayıp count değişkenine bu sayıyı atadık

            Console.WriteLine("Count : {0}", count);

        }

    }
}
