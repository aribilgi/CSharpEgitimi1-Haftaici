using System.Collections.Generic;

namespace Ders21Generics
{
    interface IRepository<T> //Bu interface e T kısmına parametre olarak bir class gelecek
    {//T ye gelecek class a göre aşağıdaki metotlar o class için çalışacak
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
