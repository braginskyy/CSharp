using MyLibraryApp.DAL.EF;
using MyLibraryApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly LibraryContext db;
        public Repository(LibraryContext db)
        {
            this.db = db;
        }
        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Create(T item)
        {
            db.Set<T>().Add(item);
        }

        public void Update(T item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void AddOrUpdate(List<T> list)
        {
            foreach (T item in list)
            {
                db.Set<T>().AddOrUpdate(item);
            }
        }
       
        public void Delete(int id)
        {
            T item = db.Set<T>().Find(id);
            if (item != null)
            {
                db.Set<T>().Remove(item);
            }
        }
    }
}
