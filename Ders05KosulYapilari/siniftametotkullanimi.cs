using System;
using System.Collections.Generic;
using System.Text;

namespace ders08sınıflar
{
    class siniftametotkullanimi
    {
        string mesaj = "";
        public siniftametotkullanimi() //ctor yazıp klavyeden tab tab yaparak oluşturulabilir.
        {
            // burası kurucu metot 
            mesaj = "kurucu metot çalıştı";
            Console.WriteLine(mesaj);
        }
        public void toplamayap()
        {
            Console.WriteLine(10+8);
        }
    }
}
