using CinemaBL.IRepository;
using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBL.IBL
{

    public interface IBaseBL : IBaseBL<IBaseDA, IEntity>
    {

    }

    public interface IBaseBL<T, E>
        where T : class, IBaseDA<E>
        where E : class, IEntity
    {
        IQueryable GetAllAsQueryable();
        void Submit(E entity);
        void Insert(E entity);
        void Update(E entity);
        void Delete(E entity);

    }

}
