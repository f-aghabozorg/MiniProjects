using CinemaBL.IBL;
using CinemaDA.Entities;
using System.Data.Entity;

namespace CinemaBL.BL
{

    public class BaseBL : BaseBL<IEntity>, IBaseBL
    {

    }
    public class BaseBL<E> : IBaseBL<E>
        where E : class , IEntity
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
        public IQueryable<E> getAllAsQueryable()
        {
            return (from p in MyDB.Set<E>()
                    select p);
        }
        protected IQueryable<E> getAllAsQueryable(string[] includeList)
        {
            IQueryable<E> query = getAllAsQueryable();
            foreach (string include in includeList)
                query = query.Include(include);
            return query;
        }
        public E GetItem(int id)
        {
            return getAllAsQueryable().Where(p => p.Id == id).Single(); //return Context.Set<T>().Find(id);
        }
        #endregion

        #region Manipulate
        public E Insert(E entity)
        {
            MyDB.Entry(entity).State = EntityState.Added;  //Context.Set<T>().Add(entity);
            Save();
            return entity;

        }

        public E Update(E entity)
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

        public E Delete(E entity)
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
                {}
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