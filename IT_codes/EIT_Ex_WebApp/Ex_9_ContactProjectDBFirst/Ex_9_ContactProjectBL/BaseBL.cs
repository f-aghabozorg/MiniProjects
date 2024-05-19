
using Ex_9_ContactProjectDBFirst;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Ex_9_ContactProjectBL
{
    public class BaseBL<T> where T : class, IEntity
    {
        #region Property
        private ContactDBEntities context;

        public ContactDBEntities Context
        {
            get
            {
                if (context == null)
                    context = new ContactDBEntities();
                return context;
            }
            set { context = value; }
        }
        private string connectionString = null;

        public string ConnectionString
        {
            get
            {
                if (connectionString == null)
                    connectionString = "";//ConfigurationManager.ConnectionStrings["ContactConnectionString"].ConnectionString;
                return connectionString;
            }
            set { connectionString = value; }
        }


        #endregion

        #region Get
        protected IQueryable<T> getAllAsQueryable()
        {
            return (from p in Context.Set<T>()
                    select p);
        }
        protected IQueryable<T> getAllAsQueryable(string[] includeList)
        {
            IQueryable<T> query = getAllAsQueryable();
            foreach (string include in includeList)
                query = query.Include(include);
            return query;
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
            var entities = Context.ChangeTracker.Entries().Where(p => p.State != EntityState.Unchanged);
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
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion
        #region ADO
        public DataTable ExcecuteADO(string query, Dictionary<string, string> dic)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand com = new SqlCommand(query, connection);
                    if (dic != null)
                    {
                        foreach (var injectParam in dic)
                        {
                            com.Parameters.AddWithValue(injectParam.Key, injectParam.Value);
                        }
                    }
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    return dt;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion
    }
}
