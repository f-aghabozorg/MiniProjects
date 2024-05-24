using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Ex_15_2_DtoUniversityCMN;

namespace Ex_15_2_DtoUniversityBL
{
    public class BaseBL : BaseBL<IBaseDA,IEntity> ,IBaseBL
    {

    }
    public class BaseBL<T,E> :IBaseBL<T,E>
        where T : class, IBaseDA<E>
        where E : class, IEntity
    {
        public virtual void Submit(E entity)
        {
            UnityManager.Container.Resolve<IBaseDA>().Save();
            //((T)Activator.CreateInstance<T>()).Save();    //reflection
        }
        public virtual void Insert(E entity)
        {
            UnityManager.Container.Resolve<IBaseDA>().Insert(entity);

        }

        public virtual void Update(E entity)
        {
            UnityManager.Container.Resolve<IBaseDA>().Update(entity);
        }

        public virtual void Delete(E entity)
        {
            UnityManager.Container.Resolve<IBaseDA>().Delete(entity);
        }
    }
}
