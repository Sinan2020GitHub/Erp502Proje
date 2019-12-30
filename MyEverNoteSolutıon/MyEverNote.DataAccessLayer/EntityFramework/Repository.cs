using MyeverNote.Common;
using MyEverNote.DataAccessLayer;
using MyEverNote.DataAccessLayer.Abstract;
using MyEverNote.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyeverNote.DataAccessLayer.EntityFramework
{
    public class Repository<T>:RepositoryBase,IRepository<T> where T:class //T nesnesi class olmalı
    {
      //private DatabaseContext db = new DatabaseContext();
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

            if(obj is BaseEntities)
            {
                //baseentities türü,ne bu obj casting işlemi yaparak dönüştürüyorum.
                BaseEntities o = obj as BaseEntities;
                DateTime now = DateTime.Now;
                o.CreatedOn = now;
                o.ModifiedOn = now;
                //now ı sabitledik çümkü hepsi aynı zamanda olması için. yoksa salise farkı olurdu
                //o.ModifiedUserName = "system";
                o.ModifiedUserName = App.Common.GetCurrentUserName();
            }

            return Save();  //her seferinde db.savechanges yazmamak için yaptık.
        }
        public int Update(T obj)
        {
            //baseentities türüne bu obj casting işlemi yaparak dönüştürüyorum.
            BaseEntities o = obj as BaseEntities;
            DateTime now = DateTime.Now;
            
            o.ModifiedOn = now;
            //o.ModifiedUserName = "system";
            o.ModifiedUserName = App.Common.GetCurrentUserName();
            return Save();
        }
        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public int Save()
        {
            return db.SaveChanges();  
        }

        public IQueryable<T> ListQeryable()
        {
            return _objectSet.AsQueryable<T>();
            //Iqueryable sorgu bitmez ucu açık kalır.
            //listeden farkı zamandan kazanç sağlıyor.Yükü sql e bırakıyor.

        }
    }
}
