using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09ErisimBelirleyiciler
{
    class Kullanici
    {
        public string Adi; //Program class ında bu değişkene ulaşmak için string in önüne public ekledik, yoksa orada erişemiyoruz
        internal string Soyadi;//Bir diğer erişim yöntemi de string in önüne internal yazmak, böylece aynı projede olduğu için bu değişken de ulaşılabilir hale geliyor
        private string Telefon;//Buradaki telefon değişkeni ise private yaptığımız için program class ında gelmez ama bu class da kullanabiliriz
        protected string Email;//bu email değişkenine de program cs den erişemeyiz protected yaptığımız için, bu sınıfta veya buradan miras alan bir sınıfta kullanabiliriz
        string sifre;
    }
}
