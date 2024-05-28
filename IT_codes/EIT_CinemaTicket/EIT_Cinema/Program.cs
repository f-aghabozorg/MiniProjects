using CinemaCMN;
using CinemaBL.BL;
using CinemaBL.IRepository;
using CinemaBL.IBL;
using CinemaDA.Repository;
using CinemaDA.Entities;
using Unity;
using static CinemaDA.Entities.Item;
using EIT_Cinema;

///////////////////////////////////////////////////////////////////////////////////////////////////

Test.StartApp();

IUserBL UserBL;
ICinemaBL CinemaBL;
ICityBL CityBL;
IItemBL ItemBL;
IReservationBL ReservationBL;
IRoomBL RoomBL;
ISeatBL SeatBL;
IShowBL ShowBL;

Test.UnityResolve(out CinemaBL, out CityBL, out ItemBL,
                  out ReservationBL, out RoomBL,
                  out SeatBL, out ShowBL, out UserBL);

Cinema Cinema;
City City;
Item Item;
Reservation Reservation;
Room Room;
Seat Seat;
Show Show;
User User;

Test.CreateEntity(out Cinema, out City, out Item, out Reservation
                , out Room, out Seat, out Show, out User
                , CinemaBL,  CityBL,  ItemBL, ReservationBL
                , RoomBL , SeatBL,  ShowBL,  UserBL);

Console.WriteLine("Completed!");


///////////////////////////////////////////////////////////////////////////////////////////////////