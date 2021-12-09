using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (UrunDbContext context = new UrunDbContext())//entity framework üzerinden db işlemlerini yapabilmek için
            {
                return context.Products.ToList();//GetAll metodunun çağrıldığı yere ürün listesini döndür
            }
        }

        public void Add(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(product); //urun nesnesi oluştur ve context deki product a abone ol 
                urun.State = EntityState.Added; // urun nesnesinin durumunu added ile eklenecek olarak değiştir
                context.SaveChanges(); //değişiklikleri kaydet
            }
        }

        public void Update(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(product);
                urun.State = EntityState.Modified; //parametreden gelen ürüne abone olunarak durumu EntityState.Modified ile değiştirilmek üzere ayarlandı
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(product);
                urun.State = EntityState.Deleted; // deleted yani silinecek olarak işaretledik
                context.SaveChanges();
            }
        }

        public Product Find(int id)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                return context.Products.Find(id);
            }
        }

    }
}
