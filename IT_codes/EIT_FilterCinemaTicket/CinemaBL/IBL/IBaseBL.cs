using CinemaDA.Entities;

namespace CinemaBL.IBL
{

    public interface IBaseBL : IBaseBL<IEntity>
    {

    }

    public interface IBaseBL<E>
        where E : class, IEntity
    {
        #region Get
        IQueryable<E> getAllAsQueryable();
        E GetItem(int id);
        #endregion

        #region manipulate
        E Insert(E entity);
        E Update(E entity);
        E Delete(E entity);
        void Save();
        #endregion

    }

}
