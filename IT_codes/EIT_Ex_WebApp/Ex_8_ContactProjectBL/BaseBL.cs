using Ex_8_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_ContactProjectBL
{
    public class BaseBL<T> where T : class, IEntity
    {
        #region Property
        private ContactContext context;

        public ContactContext Context
        {
            get
            {
                if (context == null)
                    context = new ContactContext();
                return context;
            }
            set { context = value; }
        }
        #endregion

        #region Get
        protected IQueryable<T> getAllAsQueryable()
        {
            return (from p in Context.Set<T>()
                    select p);
        }
        public T GetItemWithId(int id)
        {
            return getAllAsQueryable().Where(p => p.Id == id).Single(); //return Context.Set<T>().Find(id);
        }
        #endregion

        #region Manipulate
        protected T Insert(T entity)
        {
            Context.Entry(entity).State = EntityState.Added;  //Context.Set<T>().Add(entity);
            Save();
            return entity;

        }

        protected T Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Save();
            return entity;
        }
        protected bool Update()
        {
            //Context.Entry(entity).State = EntityState.Modified;
            Save();
            return true;

        }

        protected T Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            Save();
            return entity;

        }

        protected bool Save()
        {
            var entities = context.ChangeTracker.Entries().Where(p => p.State != EntityState.Unchanged);
            foreach (var entity in entities)
            {
                try
                {
                    if (entity.State == EntityState.Added)
                       // (entity as IEntity).Id = getAllAsQueryable().Any() ? getAllAsQueryable().Max(p => p.Id) + 1 : 1;
                    entity.Property("Id").CurrentValue = getAllAsQueryable().Any() ? getAllAsQueryable().Max(p => p.Id) + 1 : 1;
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion
    }
}
