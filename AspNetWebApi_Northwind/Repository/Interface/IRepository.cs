using AspNetWebApi_Northwind.Models.Interface;

namespace AspNetWebApi_Northwind.Repository.Interface
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        void Add(T item);
        void Edit(T item);
        void Remove(T item);
        T GetById(Func<T, bool> exp);
        List<T> GetAll();
        List<T> GetBy(Func<T, bool> exp);
    }
}
