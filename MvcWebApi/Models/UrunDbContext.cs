using MvcWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebApi.Models
{
    public class UrunDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}