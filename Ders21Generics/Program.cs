using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders21Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { ProductName = "Laptop Recai" };
            ProductDal productDal = new ProductDal();
            productDal.Add(product);
            productDal.Update(product);
            productDal.Delete(product);

            Console.WriteLine();

            Product product2 = new Product() { ProductName = "Monitör" };
            ProductDal2 productDal2 = new ProductDal2();
            productDal2.Add(product2);
            productDal2.Delete(product2);

            Console.Read();
        }

    }

    //Generic kullanmadan interface yapısı
    interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
    }

    interface ICategoryDal
    {
        List<Category> GetAll();
        Category Get(int id);
        void Add(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            Console.WriteLine(entity.ProductName + " ürünü eklendi!");
        }

        public void Delete(Product entity)
        {
            Console.WriteLine(entity.ProductName + " ürünü silindi!");
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            Console.WriteLine(entity.ProductName + " ürünü güncellendi!");
        }
    }

    class CategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            Console.WriteLine(entity.CategoryName + " eklendi!");
        }

        public void Delete(Category entity)
        {
            Console.WriteLine(entity.CategoryName + " silindi!");
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            Console.WriteLine(entity.CategoryName + " güncellendi!");
        }
    }

    interface IProductDal2 : IRepository<Product> //IRepository e parametre olarak product classını gönderdik böylece repositorydeki metotlar product için çalışacak
    {
        //Product a özel metot imzası ekleyebiliriz buraya
    }
    interface ICategoryDal2 : IRepository<Category> //IRepository e parametre olarak Category classını gönderdik böylece repositorydeki metotlar Category için çalışacak
    {

    }

    class ProductDal2 : IProductDal2
    {
        public void Add(Product entity)
        {
            Console.WriteLine(entity.ProductName + " ürünü eklendi!");
        }

        public void Delete(Product entity)
        {
            Console.WriteLine(entity.ProductName + " ürünü silindi!");
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CategoryDal2 : ICategoryDal2
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
