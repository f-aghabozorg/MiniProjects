using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaBL.IRepository;

namespace CinemaDA.Repository
{
    public class BaseDA : BaseDA<IEntity>, IBaseDA
    {

    }
    //public class BaseDA<T> : IBaseDA<T>
    public abstract class BaseDA<T> : IBaseDA<T>
    where T : class, IEntity
    {
        #region Properties
        private static CinemaContext myDB;

        private CinemaContext MyDB
        {
            get
            {
                if (myDB == null)
                    myDB = new CinemaContext();
                return myDB;
            }
            set { myDB = value; }
        }
        #endregion

        #region Get
        protected IQueryable<T> GetAllAsQueryable()
        {
            return (from p in MyDB.Set<T>()
                    select p);
        }
        protected IQueryable<T> GetAllAsQueryable(string[] includeList)
        {
            IQueryable<T> query = GetAllAsQueryable();
            foreach (string include in includeList)
                query = query.Include(include);
            return query;
        }
        public T GetItem(int id)
        {
            return GetAllAsQueryable().Where(p => p.Id == id).Single(); //return Context.Set<T>().Find(id);
        }
        #endregion

        #region Manipulate
        public T Insert(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Added;  //Context.Set<T>().Add(entity);
            Save();
            return entity;

        }

        public T Update(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Modified;
            Save();
            return entity;
        }
        public bool Update()
        {
            //MyDB.Entry(entity).State = EntityState.Modified;
            Save();
            return true;

        }

        public T Delete(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Deleted;
            Save();
            return entity;

        }

        public void Save()
        {
            var entities = MyDB.ChangeTracker.Entries().Where(p => p.State != EntityState.Unchanged);
            foreach (var entity in entities)
            {
                try
                {
                    //if (entity.State == EntityState.Added)
                    //(entity as IEntity).Id = GetAllAsQueryable().Any() ? GetAllAsQueryable().Max(p => p.Id) + 1 : 1;
                    //entity.Property("Id").CurrentValue = GetAllAsQueryable().Any() ? GetAllAsQueryable().Max(p => p.Id) + 1 : 1;
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            try
            {
                MyDB.SaveChanges();
            }
            catch (Exception ex)
            {
            }

        }
        #endregion

    }
}
