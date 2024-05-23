using Ex_15_UniversityBL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15_UniversityDA
{
    public class BaseDA : BaseDA<IEntity>, IBaseDA
    {

    }
    public class BaseDA<T>: IBaseDA<T> 
    where T : class, IEntity
    {
        #region Properties
        private static UniversityContext myDB;

        private UniversityContext MyDB
        {
            get
            {
                if (myDB == null)
                    myDB = new UniversityContext();
                return myDB;
            }
            set { myDB = value; }
        }
        #endregion

        #region Get
        protected IQueryable<T> getAllAsQueryable()
        {
            return (from p in MyDB.Set<T>()
                    select p);
        }
        protected IQueryable<T> getAllAsQueryable(string[] includeList)
        {
            IQueryable<T> query = getAllAsQueryable();
            foreach (string include in includeList)
                query = query.Include(include);
            return query;
        }
        public T GetItem(int id)
        {
            return getAllAsQueryable().Where(p => p.Id == id).Single(); //return Context.Set<T>().Find(id);
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
                    if (entity.State == EntityState.Added)
                        //(entity as IEntity).Id = getAllAsQueryable().Any() ? getAllAsQueryable().Max(p => p.Id) + 1 : 1;
                        entity.Property("Id").CurrentValue = getAllAsQueryable().Any() ? getAllAsQueryable().Max(p => p.Id) + 1 : 1;
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
