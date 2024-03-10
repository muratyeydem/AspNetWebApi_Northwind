using AspNetWebApi_Northwind.Models.Entities;
using AspNetWebApi_Northwind.Models.Interface;
using AspNetWebApi_Northwind.Repository.Interface;
using System;

namespace AspNetWebApi_Northwind.Repository.Abstract
{
    public class BaseRepository<T> : IRepository<T> where T : class,IEntity, new()
    {

        private readonly NorthwindContext db;

        public BaseRepository(NorthwindContext context)
        {
            this.db = context;
        }

        public void Add(T item)
        {
            try
            {
                db.Set<T>().Add(item);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception($"Ekleme İşlemi Sırasında Hata Meydana Geldi....Hata Mesajı=>{ex.Message}");
            }
            
        }

        public void Remove(T item)
        {
            try
            {
                db.Set<T>().Remove(item);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception($"Silme İşlemi Sırasında Hata Meydana Geldi....Hata Mesajı=>{ex.Message}");
            }
        }

        public T GetById(Func<T, bool> exp)
        {
            return db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> GetBy(Func<T, bool> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }

        public void Edit(T item)
        {
            try
            {
                db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception($"Guncelleme İşlemi Sırasında Hata Meydana Geldi....Hata Mesajı=>{ex.Message}");
            }
        }
    }
}