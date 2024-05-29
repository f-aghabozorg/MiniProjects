using CinemaBL.DTO;
using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBL.IRepository
{
    public interface IShowDA : IBaseDA<Show>
    {
        List<DTO_ShowTime> ShowTimeListForCinema(string CinemaName, DateTime Date);
        List<DTO_CinemaShowTime> ShowListMovieForCinema(string MovieTitle);
    }
}
