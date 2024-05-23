using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_13_IOCTextBL;


namespace Ex_13_IOCTextBL
{
    public interface IBaseBL<T> where T : class, IEntity
    {
        //int GetCount();
        //IQueryable<T> getAllAsQueryable();
        //IQueryable<T> getAllAsQueryable(string[] includeList);
        T GetItemWithId(int id);
        T Insert(T entity);
        T Update(T entity);
        T Delete(T entity);
        //bool Save();
        //DataTable ExcecuteADO(string query, Dictionary<string, string> dic);
    }
}
