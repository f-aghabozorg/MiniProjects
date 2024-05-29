using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBL.IRepository
{
    public interface IReservationDA : IBaseDA<Reservation>
    {
        int CountTodayReservation();
        int CountDateToDateReservation(DateTime StartDate, DateTime EndDate);
        int CountDateToDateReservationForCinema(DateTime StartDate, DateTime EndDate, string CinemaName);
        int CountCancellDateToDateReservation(DateTime StartDate, DateTime EndDate);
    }
}
