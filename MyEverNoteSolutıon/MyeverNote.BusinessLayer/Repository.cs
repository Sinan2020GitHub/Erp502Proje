using MyEverNote.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyeverNote.BusinessLayer
{
    public class Repository<T> where T:class //T nesnesi class olmalı
    {
        private DatabaseContext db = new DatabaseContext();
        private DbSet<T> _objectSet;
        public Repository()
        {
            _objectSet = db.Set<T>();

        }

        public List<T> List()
        {
            //return db.Set<T>().ToList();
            return _objectSet.ToList();
        }
        public List<T> List(Expression<Func<T,bool>>where) 
        {
            return _objectSet.Where(where).ToList();
            //db.Categories.Where(x => x.Id == 1).ToList(); expression ın içi x=>x.ıd li ksımla aynı
        }
        public T Find(Expression<Func<T, bool>> where) 
        {
            return _objectSet.FirstOrDefault(where);
            
        }
        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();  //her seferinde db.savechanges yazmamak için yaptık.

        }
        public int Update(T obj)
        {
            return Save();

        }
        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();

        }

        private int Save()
        {
            return db.SaveChanges();  
        }
    }
}
