using CinemaBL.IRepository;

using CinemaDA.Entities;

using System;

using System.Collections.Generic;

using System.Data.Entity.Core.Objects;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace CinemaDA.Repository

{

    public class ReservationDA : BaseDA<Reservation>, IReservationDA

    {

        //چند نفر امروز رزرو کرده اند؟

        public int CountTodayReservation()

        {

            return GetAllAsQueryable()

                   .Count(x => EntityFunctions.TruncateTime(x.Show.Date) == DateTime.Today.Date);

        }





        //از تاریخ فلان تا فلان چند نفر رزرو کرده اند؟

        public int CountDateToDateReservation(DateTime StartDate, DateTime EndDate)

        {

            return GetAllAsQueryable()

                   .Where(x => EntityFunctions.TruncateTime(x.Show.Date) >= StartDate.Date

                          && EntityFunctions.TruncateTime(x.Show.Date) <= EndDate.Date)

                   .Count();

        }







        //برای سینمای مشخصی از تاریخ فلان تا فلان چند نفر رزرو کرده اند؟

        public int CountDateToDateReservationForCinema(DateTime StartDate, DateTime EndDate, string CinemaName)

        {

            return GetAllAsQueryable()

                   .Where(x => EntityFunctions.TruncateTime(x.Show.Date) >= StartDate.Date

                          && EntityFunctions.TruncateTime(x.Show.Date) <= EndDate.Date

                          && x.Show.Room.Cinema.Name == CinemaName)

                   .Count();

        }







        //از تاریخ فلان تا فلان چند نفر لغو کرده اند؟

        public int CountCancellDateToDateReservation(DateTime StartDate, DateTime EndDate)

        {

            return GetAllAsQueryable()

                   .Where(x => EntityFunctions.TruncateTime(x.Show.Date) >= StartDate.Date

                          && EntityFunctions.TruncateTime(x.Show.Date) <= EndDate.Date

                          && x.IsCancell == true)

                   .Count();

        }

        public int GetReserveCount(ReserveDto reserveDto)

        {

            return GetAllAsQueryable()

                .Count(p => (reserveDto.CinamaName == "" || p.Show.Room.Cinema.Name == reserveDto.CinamaName)

                && (reserveDto.StartDateTime == null || EntityFunctions.TruncateTime(p.Show.Date) >= reserveDto.StartDateTime.Value.Date)

                && (reserveDto.EndDateTime == null || EntityFunctions.TruncateTime(p.Show.Date) <= reserveDto.EndDateTime.Value.Date));

        }



    }

    public class ReserveDto

    {

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public string CinamaName { get; set; }

    }

}







