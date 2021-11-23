using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Product(30);
            laptop.ProductName = "Monster notebook";

            Product telefon = new Product(45);
            telefon.ProductName = "Telefon";
            telefon.StockControlEvent += Gsm_StockControlEvent;
            Console.WriteLine("Satış yapmak için enter a basın");
            int satisMiktari = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {

                laptop.Satis(satisMiktari);
                telefon.Satis(satisMiktari);
                satisMiktari = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
        }
        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Telefon stokları tükendi!");
        }
    }
}
