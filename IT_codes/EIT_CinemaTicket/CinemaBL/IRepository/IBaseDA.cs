﻿using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBL.IRepository
{
    public interface IBaseDA : IBaseDA<IEntity>
    {

    }

    public interface IBaseDA<T> where T : class, IEntity
    {
        #region Get
        //IQueryable<T> GetAllAsQueryable();
        T GetItem(int id);
        #endregion

        #region manipulate
        T Insert(T entity);
        T Update(T entity);
        T Delete(T entity);
        void Save();
        #endregion
    }
}
