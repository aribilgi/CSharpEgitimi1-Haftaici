using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public class UrunDbContext : DbContext //UrunDbContext bizim veritabanı yönetim contextimiz, DbContext ise entity framework ün 
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Kategoriler> Kategoriler { get; set; }
    }
}
