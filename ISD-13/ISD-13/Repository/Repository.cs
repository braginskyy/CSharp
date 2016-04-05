using ISD_13.Data;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Context db;
        public Repository(Context db)
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

        public void Delete(int id)
        {
            T item = db.Set<T>().Find(id);
            if (item != null)
            {
                db.Set<T>().Remove(item);                
            }
        }
        //public void SaveEdit(List<T> list)
        //{
        //    foreach (T p in list)
        //    {
        //        if (GetAll().Any(x => x.Id == p.Id))
        //        {
        //            Update(p);

        //        }
        //        else
        //        {
        //            Create(p);
        //        }
        //    }
        //    Delete(list);
        //}

        //public void Delete(List<T> list)
        //{
        //    var query = GetAll().Except(list);
        //    foreach (var p in query)
        //    {
        //        Delete(p.Id);
        //    }
        //}
    }
}
