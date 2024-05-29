using CinemaBL.DTO;
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
    public class ShowDA: BaseDA<Show>, IShowDA
    {
        //برای یک سینمای مشخص در فلان روز سانس ها در چه ساعاتی هست؟
        public List<DTO_ShowTime> ShowTimeListForCinema(string CinemaName, DateTime Date)
        {
            return GetAllAsQueryable()
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

        //برای یک فیلم مشخص چه سینماهایی در چه سانس هایی این فیلم اکران میشود؟
        public List<DTO_CinemaShowTime> ShowListMovieForCinema(string MovieTitle)
        {
            return GetAllAsQueryable()
                   .Where(x => x.Item.Title == MovieTitle
                              && x.Item.ItemType == Item.Item_Type.Movie)
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
