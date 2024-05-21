using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_13_IOCTextDA;
using System.Data.Entity;

namespace Ex_13_IOCTextBL
{
    public class BaseBL<T> : IBaseBL<T>
        where T : class, IEntity 
    {
        public virtual int GetCount()
        {
            return 0;
        }

        #region Property
        private IOCTextContext myDB;

        public IOCTextContext MyDB
        {
            get
            {
                if (myDB == null)
                    myDB = new IOCTextContext();
                return myDB;
            }
            set { myDB = value; }
        }
        private string connectionString = "";

        public virtual string ConnectionString
        {
            get
            {
                if (connectionString == null)
                    connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["TextIOCConnectionString"].ConnectionString;
                return connectionString;
            }
            set { connectionString = value; }
        }


        #endregion

        #region Get
        public virtual IQueryable<T> getAllAsQueryable()
        {
            return (from p in MyDB.Set<T>()
                    select p);
        }
        public virtual IQueryable<T> getAllAsQueryable(string[] includeList)
        {
            IQueryable<T> query = getAllAsQueryable();
            foreach (string include in includeList)
                query = query.Include(include);
            return query;
        }

        public virtual T GetItemWithId(int id)
        {
            return getAllAsQueryable().Where(p => p.Id == id).Single(); //return Context.Set<T>().Find(id);
        }
        #endregion

        #region Manipulate
        public virtual T Insert(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Added;  //Context.Set<T>().Add(entity);
            Save();
            return entity;

        }

        public virtual T Update(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Modified;
            Save();
            return entity;
        }
        public virtual bool Update()
        {
            //MyDB.Entry(entity).State = EntityState.Modified;
            Save();
            return true;

        }

        public virtual T Delete(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Deleted;
            Save();
            return entity;

        }

        public virtual bool Save()
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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion
        #region ADO
        public virtual DataTable ExcecuteADO(string query, Dictionary<string, string> dic)
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
