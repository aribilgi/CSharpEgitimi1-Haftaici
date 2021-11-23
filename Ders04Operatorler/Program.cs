using System;

namespace Ders04Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Aritmetik Operatörler
            int a = 50;
            int b = 20;
            int c = 30;

            int sonuc = a + b;
            int sonuc1 = a - b;
            int sonuc2 = a * b;
            float sonuc3 = (float)a / (float)b;

            int sonuc4 = a % b;
            c--; //c nin değerini 1 azalt
            int sonuc5 = c;

            b++; //b nin değerini 1 artır
            int sonuc6 = b;

            Console.WriteLine("a + b " + sonuc);
            Console.WriteLine("a - b " + sonuc1);
            Console.WriteLine("a * b " + sonuc2);
            Console.WriteLine("a / b " + sonuc3);
            Console.WriteLine("a % b " + sonuc4);
            Console.WriteLine("c-- " + sonuc5);
            Console.WriteLine("b++ " + sonuc6);

            //2- Atama Operatörleri (=,+=,-=,*=,/=,%=)

            Console.WriteLine(a += b);
            Console.WriteLine(a = a + b);
            Console.WriteLine(a -= b);
            Console.WriteLine(a *= b);
            Console.WriteLine(a /= b);
            Console.WriteLine(a %= b);

            //3-İlişkisel Operatörler (==,!=,<,>,<=,>=,?:)

            Console.WriteLine(a == b); //a b ye eşit mi
            Console.WriteLine(a != b); //a b ye eşit değil mi
            Console.WriteLine(a > b); //a b den büyük mü
            Console.WriteLine(a < b);// a b den küçük mü
            Console.WriteLine(a <= b); //a b den küçük mü veya b ye eşit mi
            Console.WriteLine(a >= b); //a b den büyük mü veya eşit mi

            Console.WriteLine((a == b) ? "a b ye eşit" : "a b ye eşit değil");

            //Mantıksal Operatörler
            Console.WriteLine((5 > 3) && (4 > 5)); //a b den büyük mü VE a c den büyük mü

            Console.WriteLine((5 > 3) || (5 > 7));//a b den büyük mü VEYA a c den büyük mü

            Console.WriteLine(!(5 > 3));
        }
    }
}
