using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15_UniversityBL
{
    public interface IBaseBL<T, E>
        where T : class, IBaseDA<E>
        where E : class, IEntity
    {

        void Submit(E entity);
    }
}
