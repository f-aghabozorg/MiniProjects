using CinemaBL.BL;
using CinemaBL.IBL;
using CinemaBL.IRepository;
using CinemaCMN;
using CinemaDA.Repository;
using CinemaDA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CinemaDA.Entities.Item;
using Unity;

namespace EIT_Cinema
{
    public class Test
    {
        static void RegisterT<I,D>() where D : class , I => UnityManager.Container.RegisterType<I,D>();
        public static void StartApp()
        {
            RegisterT<IBaseDA, BaseDA>();
            RegisterT<ICinemaDA, CinemaDA.Repository.CinemaDA>();
            RegisterT<ICityDA, CityDA>();
            RegisterT<IItemDA, ItemDA>();
            RegisterT<IReservationDA, ReservationDA>();
            RegisterT<IRoomDA, RoomDA>();
            RegisterT<ISeatDA, SeatDA>();
            RegisterT<IShowDA, ShowDA>();
            RegisterT<IUserDA, UserDA>();

            RegisterT<IBaseBL, BaseBL>();
            RegisterT<ICinemaBL, CinemaBL.BL.CinemaBL>();
            RegisterT<ICityBL, CityBL>();
            RegisterT<IItemBL, ItemBL>();
            RegisterT<IReservationBL, ReservationBL>();
            RegisterT<IRoomBL, RoomBL>();
            RegisterT<ISeatBL, SeatBL>();
            RegisterT<IShowBL, ShowBL>();
            RegisterT<IUserBL, UserBL>();
        }

        public static void CreateEntity( out Cinema Cinema, out City City
                                , out Item Item, out Reservation Reservation
                                , out Room Room, out Seat Seat, out Show Show, out User User
                                , ICinemaBL CinemaBL, ICityBL CityBL, IItemBL ItemBL
                                , IReservationBL ReservationBL, IRoomBL RoomBL
                                , ISeatBL SeatBL, IShowBL ShowBL, IUserBL UserBL)
        {
            City = new City()
            {
                Name = "Mashad"
            };
            CityBL.Insert(City);

            Item = new Item()
            {
                Title = "Texas-3",
                Duration = 3,
                Director = "Mr-x",
                Genre = "Tanz",
                ItemType = Item_Type.Movie
            };
            ItemBL.Insert(Item);

            User = new User()
            {
                Name = "Ali Alavi",
                Email = "Ali@gmail.com",
                Phone = "09381425786",
                Password = "12345"
            };
            UserBL.Insert(User);


            Cinema = new Cinema()
            {
                Name = "Cinema Azadi"
                ,
                CityId = City.Id
                ,
                Room = new List<Room>(){
            //Room,
            new Room()
            {
                Name = "Salon_Mashahir",
                Capacity = 30,
                RowCount =3,
            },
            new Room()
            {
                Name = "Salon_Tanz",
                Capacity = 40,
                RowCount =4,
            }
        }
            };
            CinemaBL.Insert(Cinema);


            Room = new Room()
            {
                Name = "Salon_Honar",
                Capacity = 40,
                RowCount = 4,
                CinemaId = Cinema.Id
            };
            RoomBL.Insert(Room);


            Show = new Show()
            {
                Item = Item,
                ItemId = Item.Id,
                RoomId = Room.Id,
                Date = DateTime.Now,
                StartTime = 12,
                EndTime = 15
            };
            ShowBL.Insert(Show);


            Seat = new Seat()
            {
                Row = 1,
                Number = 1
            };
            SeatBL.Insert(Seat);

            Reservation = new Reservation()
            {
                UserId = User.Id,
                ShowId = Show.Id,
                SeatId = Seat.Id,
                IsCancell = false,
                Price = 200000

            };
            ReservationBL.Insert(Reservation);

        }
        static T Resolve<T>() => UnityManager.Container.Resolve<T>();
        public static void UnityResolve(out ICinemaBL CinemaBL, out ICityBL CityBL, out IItemBL ItemBL,
                                out IReservationBL ReservationBL, out IRoomBL RoomBL,
                                out ISeatBL SeatBL, out IShowBL ShowBL, out IUserBL UserBL)
        {
            CinemaBL = Resolve<ICinemaBL>();
            CinemaBL = Resolve<ICinemaBL>();
            CityBL = Resolve<ICityBL>();
            ItemBL = Resolve<IItemBL>();
            ReservationBL = Resolve<IReservationBL>();
            RoomBL = Resolve<IRoomBL>();
            SeatBL = Resolve<ISeatBL>();
            ShowBL = Resolve<IShowBL>();
            UserBL = Resolve<IUserBL>();
        }
    }
}
