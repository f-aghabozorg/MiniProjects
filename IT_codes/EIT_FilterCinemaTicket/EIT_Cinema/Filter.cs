using CinemaBL.IBL;
using System.Data.Entity.Core.Objects;
using System.Globalization;

namespace EIT_Cinema
{
    public class Filter
    {


        //چند نفر امروز رزرو کرده اند؟
        public static int CountTodayReservation(IReservationBL ReservationBL)
        {
            return ReservationBL.getAllAsQueryable()
                                 .Where(x => EntityFunctions.TruncateTime(x.Show.Date) == DateTime.Today.Date)
                                 .Count();
        }



        //از تاریخ فلان تا فلان چند نفر رزرو کرده اند؟
        public static int CountDateToDateReservation(IReservationBL ReservationBL, DateTime StartDate , DateTime EndDate)
        {
            return ReservationBL.getAllAsQueryable()
                                 .Where(x => EntityFunctions.TruncateTime(x.Show.Date) >= StartDate.Date
                                             && EntityFunctions.TruncateTime(x.Show.Date) <= EndDate.Date)
                                 .Count();
        }



        //برای سینمای مشخصی از تاریخ فلان تا فلان چند نفر رزرو کرده اند؟
        public static int CountDateToDateReservationForCinema(IReservationBL ReservationBL, DateTime StartDate, DateTime EndDate, string CinemaName)
        {
            return ReservationBL.getAllAsQueryable()
                                 .Where(x => EntityFunctions.TruncateTime(x.Show.Date) >= StartDate.Date
                                             && EntityFunctions.TruncateTime(x.Show.Date) <= EndDate.Date
                                             && x.Show.Room.Cinema.Name == CinemaName)
                                 .Count();
        }


        //از تاریخ فلان تا فلان چند نفر لغو کرده اند؟
        public static int CountCancellDateToDateReservation(IReservationBL ReservationBL, DateTime StartDate, DateTime EndDate)
        {
            return ReservationBL.getAllAsQueryable()
                                .Where(x => EntityFunctions.TruncateTime(x.Show.Date) >= StartDate.Date
                                            && EntityFunctions.TruncateTime(x.Show.Date) <= EndDate.Date
                                            && x.IsCancell == true)
                                .Count();
        }

        public class DTO_ShowTime
        {
            public int StartTime { get; set; }
            public int EndTime { get; set; }

        }

        //برای یک سینمای مشخص در فلان روز سانس ها در چه ساعاتی هست؟
        public static List<DTO_ShowTime> ShowTimeListForCinema(IShowBL ShowBL, string CinemaName, DateTime Date)
        {
            return ShowBL.getAllAsQueryable()
                          .Where(x => x.Room.Cinema.Name == CinemaName
                                     && EntityFunctions.TruncateTime(x.Date) == Date.Date)
                          .Select(x => new DTO_ShowTime
                          {
                             StartTime = x.StartTime
                                          ,
                              EndTime = x.EndTime
                          })
                          .ToList();
        }
        public class DTO_CinemaShowTime
        {
            public string CinemaName { get; set; }
            public int StartTime { get; set; }
            public int EndTime { get; set; }

        }

        //برای یک فیلم مشخص چه سینماهایی در چه سانس هایی این فیلم اکران میشود؟
        public static List<DTO_CinemaShowTime> ShowListMovieForCinema(IShowBL ShowBL, string MovieTitle)
        {
            return ShowBL.getAllAsQueryable()
                          .Where(x => x.Item.Title == MovieTitle
                                     && x.Item.ItemType == CinemaDA.Entities.Item.Item_Type.Movie)
                          .Select(x => new DTO_CinemaShowTime
                          {
                              CinemaName = x.Room.Cinema.Name
                              ,
                              StartTime = x.StartTime
                              ,
                              EndTime = x.EndTime
                          })
                          .ToList();
        }

        
    }
}
