using CinemaBL.IBL;
using CinemaBL.IRepository;
using CinemaCMN;
using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace CinemaBL.BL
{
    public class ReservationBL : BaseBL<IReservationDA, Reservation>, IReservationBL
    {
        private readonly IReservationDA reservationDA;
        public ReservationBL()
        {
            reservationDA = UnityManager.Container.Resolve<IReservationDA>();

        }

        //چند نفر امروز رزرو کرده اند؟
        public int CountTodayReservation()
        {
            return reservationDA.CountTodayReservation();
        }


        //از تاریخ فلان تا فلان چند نفر رزرو کرده اند؟
        public int CountDateToDateReservation(DateTime StartDate, DateTime EndDate)
        {
            return reservationDA.CountDateToDateReservation(StartDate, EndDate);
        }



        //برای سینمای مشخصی از تاریخ فلان تا فلان چند نفر رزرو کرده اند؟
        public int CountDateToDateReservationForCinema(DateTime StartDate, DateTime EndDate, string CinemaName)
        {
            return reservationDA.CountDateToDateReservationForCinema(StartDate, EndDate, CinemaName);   
        }



        //از تاریخ فلان تا فلان چند نفر لغو کرده اند؟
        public int CountCancellDateToDateReservation(DateTime StartDate, DateTime EndDate)
        {
            return reservationDA.CountCancellDateToDateReservation(StartDate,EndDate);
        }


    }
}
