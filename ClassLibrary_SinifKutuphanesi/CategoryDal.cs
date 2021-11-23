using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_SinifKutuphanesi
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            Console.WriteLine(entity.Name + " eklendi");
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
