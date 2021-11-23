using System.Collections.Generic;

namespace ClassLibrary_SinifKutuphanesi
{
    interface IRepository<T> //Bu interface e T kısmına parametre olarak bir class gelecek
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
