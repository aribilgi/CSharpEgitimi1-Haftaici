using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders15KapsullemeEncapsulation
{
    //Nesne yönelimli programlamada, kapsülleme eylemi, verinin veya metodun başka yerden görünmeyecek biçimde üstünün sınıf içinde örtülmesi demektir. Genellikle kapsüllenmiş nesneye soyut veri tipi (abstract data type) denir.
    //Neden? Kapsülleme yapmamızın nedeni her programcının yaptığı basit yanlışlarla verinin veya kodların bozulmasını önlemektir.
    //Korunmak istenen veriler public yerine private olarak nitelenir. Get, set yöntemlerini kullanarak verilere erişim sağlarız. Diğer yöntem de properties kullanımıdır.
    public class Bolum
    {
        private string BolumAdi;//dışarıdan erişime kapalı değişkenimiz. 
        //Accessor (Getter)
        public string GetBolumAdi() 
        { 
            return BolumAdi;
        }//Geriye private BolumAdi değişkenini döndüren metot
        //Mutator (Setter)
        //public void SetBolumAdi(string a) { BolumAdi = a; }//Dışarıdan aldığı a parametresini BolumAdi değişkenine atayan metot
        public void SetBolumAdi(string a)
        {
            if (a == "Yazılım Mühendisliği")
            {
                Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", a);
            }
            else BolumAdi = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Bolum bolum = new Bolum();
            //Console.WriteLine("Lütfen Bölüm Adını Giriniz;");
            //var bolumAdi = Console.ReadLine();//ekrandan alınan değeri okuyup var  ile oluşturduğumuz bolumadi değişkenine atadık
            //bolum.SetBolumAdi(bolumAdi);//bolum içerisindeki SetBolumAdi metoduna bölüm adını gönderdik, private değişkene atama yapıldı
            //Console.WriteLine("Bölüm adı : " + bolum.GetBolumAdi());//bolum içerisindeki GetBolumAdi() metodunu direk ekrana yazdırdık çünkü GetBolumAdi()

            //Fakulte fakulte = new Fakulte();
            //fakulte.Bolum = "Yazılım Mühendisliği";

            //Console.WriteLine("Fakülte = {0} {1}", fakulte.Bolum, "2.değer");

            Universite universite = new Universite("Maliye");//Universite classında bir nesne oluşturduğumuzda artık bu nesneye bir değer göndermeliyiz çünkü class ın kurucu metodunda parametrik hale getirdik sınıfı
            Console.WriteLine("Universite Bölümü : " + universite.Bolum);

            Console.Read();
        }
    }

    //Özgen (Property) kullanarak kapsülleme
    public class Fakulte
    {
        private string bolum;//Fakülte sınıfının içindeki bolum değişkenini private tanımlayarak kapsüllemiş olduk, böylece bu değişkene sadece aşağıdaki get, set metotlarıyla erişilebilir
        public string Bolum
        {
            get { return bolum; }//get bloğu içindeki return(dön) komutundan anlaşılacağı üzere geriye içerdeki private tanımladığımız kapsüllenen bolum değişkenine atanan veriyi döndürür
            set
            {
                if (value == "Yazılım Mühendisliği")
                {
                    Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", value);
                    return;
                }
                else bolum = value;
            }//set bloğu ise dışarıya açık Bolum değişkenine atanan veriyi alıp içerde kapsüllediğimiz private bolum değişkenine atar
        }
    }

    //Yalnız okunur (Read only property)
    public class Universite
    {
        private string bolum;
        public Universite(string str)
        {
            bolum = str;
        }

        public string Bolum
        {
            get
            {
                return bolum;
            }//burada set bloğu kullanmadık o yüzden dışarıdan veri atamasına kapalıdır 
        }
    }

}
