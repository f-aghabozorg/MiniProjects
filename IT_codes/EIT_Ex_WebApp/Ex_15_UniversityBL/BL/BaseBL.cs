using Ex_15_UniversityCMN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Ex_15_UniversityBL
{
    public class BaseBL<T,E> :IBaseBL<T,E>
        where T : class, IBaseDA<E>
        where E : class, IEntity
    {
        public virtual void Submit(E entity)
        {
            UnityManager.Container.Resolve<IBaseDA>().Save();
            //((T)Activator.CreateInstance<T>()).Save();    //reflection
        }

    }
}
