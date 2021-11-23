using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10OzgenlerProperties
{
    public class Kisi
    {
        private int yas;
        private string dogumyeri;
        private string meslek;
        private double maas;

        public double Maas
        {
            get { return maas; } // yukarda tanımladığımız private urunFiyati değişkeninin değerini dışarıya(Programımızda nerde çağırdıysak oraya) gönderir
            set
            {
                if (value <= 0) //Eğer private double urunFiyati; değişkenine dışarıdan 0 dan küçük bir ürün fiyatı değeri gönderilirse urunFiyati değişkeninin değerini 1 yap
                {
                    maas = 1;
                }
                else maas = value;//if şartı geçersizse dışardan gönderilen değeri içerdeki urunFiyati değişkenine ata
            }
        }

        public int Yas
        {
            get { return yas; }
            set
            {//set bloğunda dışarıdan gelen value değerine göre işlem yaptırabiliriz
                if (value <= 65 && value >= 18) yas = value;
                else yas = 18;
            }
        }

        public string DogumYeri
        {
            get { return dogumyeri; }
            set { dogumyeri = value; }
        }
    }
}
