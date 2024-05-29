using CinemaBL.DTO;
using CinemaBL.IRepository;
using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBL.IBL
{
    public interface IShowBL : IBaseBL<IBaseDA<Show>, Show>
    {
        List<DTO_ShowTime> ShowTimeListForCinema(string CinemaName, DateTime Date);
        List<DTO_CinemaShowTime> ShowListMovieForCinema(string MovieTitle);
    }
}
