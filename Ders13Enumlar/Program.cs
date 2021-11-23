using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13Enumlar
{
    class Program
    {
        //Enum(Numaratör) lar nesneleri numaralandırmak için kullanılır
        /*
         * Enum tipler üzerindeki kısıtlar
         * 1-Enum blokunda metot tanımlanamaz
         * 2-Arayüz(Interface) kullanamazlar
         * 3-enum blokunda property kullanılmaz         
         */
        enum Aylar : byte//byte koleksiyondaki numaraların veri tipinin byte türünden olacağını belirtiyor
        {
            Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        enum CalisilanGunler
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma
        }
        enum SiparisDurumu
        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, Kargolandı
        }
        enum Meyveler : int
        {
            Elma = 3, Armut = 7, Çilek = 1
        }
        static void Main(string[] args)
        {
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine("Armut = {0}, Elma={1}, Çilek={2}", a, b, c);
            Ornek1();
            Console.Read();
        }

        static void Ornek1()
        {
            byte a = (byte)Aylar.Ocak;
            byte b = (byte)Aylar.Şubat;
            byte c = (byte)Aylar.Mart;
            byte d = (byte)Aylar.Nisan;
            byte f = (byte)Aylar.Haziran;
            Console.WriteLine("Ocak = {0}, Nisan={1}, Haziran={2}", a, d, f);

            int SiparisDurum = 1;
            if (SiparisDurum == 0) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.Hazırlanıyor);
            if (SiparisDurum == 1) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.Hazırlandı);
            if (SiparisDurum == 2) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.KargoBekleniyor);
            if (SiparisDurum == 3) Console.WriteLine("Sipariş Durumu: {0}", SiparisDurumu.Kargolandı);
        }

    }
}
