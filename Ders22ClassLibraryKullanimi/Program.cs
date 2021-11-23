using System;
using ClassLibrary_SinifKutuphanesi;

namespace Ders22ClassLibraryKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oluşturduğumuz sınıf kütüphanesini kullanabilmek için öncelikle dependencies kısmından sağ tık add project references diyerek açılan pencereden  ClassLibrary_SinifKutuphanesi projesini tik atıp ok tuşuna basarak kütüphaneyi projemize referans olarak eklemeliyiz!!
            //2. adımda ClassLibrary_SinifKutuphanesi ni yukarıdan using olarak ekliyoruz
            Product product = new Product() { Name = "Klavye" };
            ProductDal productDal = new ProductDal();
            productDal.Add(product);

            Console.WriteLine("Email adresinizi giriniz:");
            var email = Console.ReadLine();
            bool mailGonderildiMi = Metotlar.MailGonder(email);
            if (mailGonderildiMi == true)
            {
                Console.WriteLine(email + " adresine mail gönderildi!");
            }
            else Console.WriteLine(email + " adresine mail gönderilemedi!");

            Console.WriteLine("Hello World!");
        }
    }
}
