
using Ex_12_1_TPH_EntekhabReshteDA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex_12_1_TPH_EntekhabReshteDA.Model;

namespace Ex_12_1_TPH_EntekhabReshteBL
{
    public class BaseBL<T> where T : class, IEntity
    {
        #region Property
        private EntekhabReshteContext myDB;

        public EntekhabReshteContext MyDB
        {
            get
            {
                if (myDB == null)
                    myDB = new EntekhabReshteContext();
                return myDB;
            }
            set { myDB = value; }
        }
        private string connectionString = "";

        public string ConnectionString
        {
            get
            {
                if (connectionString == null)
                    connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["TPH_ConnectionString"].ConnectionString;                return connectionString;
            }
            set { connectionString = value; }
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

        public T GetItemWithId(int id)
        {
            return getAllAsQueryable().Where(p => p.Id == id).Single(); //return Context.Set<T>().Find(id);
        }
        //public T GetAll()
        //{
        //    return getAllAsQueryable().All().ToList();
        //}
        #endregion

        #region Manipulate
        protected T Insert(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Added;  //Context.Set<T>().Add(entity);
            Save();
            return entity;

        }

        protected T Update(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Modified;
            Save();
            return entity;
        }
        protected bool Update()
        {
            //MyDB.Entry(entity).State = EntityState.Modified;
            Save();
            return true;

        }

        protected T Delete(T entity)
        {
            MyDB.Entry(entity).State = EntityState.Deleted;
            Save();
            return entity;

        }

        protected bool Save()
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
