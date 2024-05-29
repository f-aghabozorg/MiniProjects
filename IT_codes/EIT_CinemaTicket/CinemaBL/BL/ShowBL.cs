using CinemaBL.DTO;
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
    public class ShowBL : BaseBL<IShowDA, Show>, IShowBL
    {
        private readonly IShowDA showDA;
        public ShowBL()
        {
            showDA = UnityManager.Container.Resolve<IShowDA>();

        }

        //برای یک سینمای مشخص در فلان روز سانس ها در چه ساعاتی هست؟
        public List<DTO_ShowTime> ShowTimeListForCinema(string CinemaName, DateTime Date)
        {
            return showDA.ShowTimeListForCinema(CinemaName, Date);
        }


        //برای یک فیلم مشخص چه سینماهایی در چه سانس هایی این فیلم اکران میشود؟
        public List<DTO_CinemaShowTime> ShowListMovieForCinema(string MovieTitle)
        {
            return showDA.ShowListMovieForCinema(MovieTitle);
        }
    }
}
