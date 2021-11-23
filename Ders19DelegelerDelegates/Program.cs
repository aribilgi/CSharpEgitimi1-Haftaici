using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders20DelegelerDelegates
{
    //Delegeler (Delagates) Delegeler metot işaret eden referanslardır
    //Klasik yöntemle aracısız metot çağırma
    class Vergiler
    {
        public double BrutOku()
        {
            Console.WriteLine("Brüt gelirinizi giriniz :");
            return Double.Parse(Console.ReadLine());
        }
        public double GelirVergisiHesapla(double d)
        {
            if (d > 2824) return d * 0.40;
            else return d * 0.25;
        }
    }
    public delegate void BasitDelege();//Delege tanımlaması bu şekilde yapılıyor
    class Program
    {
        static void Topla()//Toplama yapan basit bir program
        {
            Console.WriteLine("10+8 = " + (10 + 8));
        }
        static void Main(string[] args)
        {
            Vergiler vergi = new Vergiler();
            //Console.WriteLine("Ödediğiniz Vergi : " + vergi.GelirVergisiHesapla(vergi.BrutOku()));

            BasitDelege obj = new BasitDelege(Topla);//Delege ile statik metot çağırma işlemi yaptık
            obj();

            Program u = new Program();//Program sınıfımızdan u isimli bir nesne oluşturuyoruz
            ParametreliDelege pd = new ParametreliDelege(u.Topla);//BasitDelege adlı delegemizden obj adlı bir nesne
            pd(10, 8);//BasitDelege adlı delegemizden oluşturduğumuz nesneye parametrelerini veriyoruz

            Console.Read();
        }
        public void Topla(int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }
        public delegate void ParametreliDelege(int a, int b);
        public delegate double Delege01();
        public delegate double Delege02(double dd);
    }
}
