using CinemaCMN;
using CinemaBL.BL;
using CinemaBL.IRepository;
using CinemaBL.IBL;
using CinemaDA.Repository;
using CinemaDA.Entities;
using Unity;

StartApp();

//Cinema,City,Item,Movie,Reservation,Room,Seat,Show,Theatre,User

Cinema Cinema;
City City;
Item Item;
Movie Movie;
Reservation Reservation;
Room Room;
Seat Seat;
Show Show;
Theatre Theatre;
User User;

CreateEntity(out Cinema, out City, out Item
            , out Movie, out Reservation
            , out Room, out Seat, out Show
            , out Theatre, out User
            );

IUserBL UserBL;
ICinemaBL CinemaBL;
ICityBL CityBL;
IItemBL ItemBL;
IMovieBL MovieBL;
IReservationBL ReservationBL ;
IRoomBL RoomBL;
ISeatBL SeatBL;
IShowBL ShowBL;
ITheatreBL theatreBL;

UnityResolve(out CinemaBL,out CityBL, out ItemBL,
             out MovieBL, out ReservationBL, out RoomBL,
             out SeatBL, out ShowBL, out theatreBL, out UserBL
             );

UserBL.Insert(User);



Console.WriteLine("Hello, World!");

static void StartApp()
{
    UnityManager.Container.RegisterType<IBaseDA, BaseDA>();
    UnityManager.Container.RegisterType<ICinemaDA, CinemaDA.Repository.CinemaDA>();
    UnityManager.Container.RegisterType<ICityDA, CityDA>();
    UnityManager.Container.RegisterType<IItemDA, ItemDA>();
    UnityManager.Container.RegisterType<IMovieDA, MovieDA>();
    UnityManager.Container.RegisterType<IReservationDA, ReservationDA>();
    UnityManager.Container.RegisterType<IRoomDA, RoomDA>();
    UnityManager.Container.RegisterType<ISeatDA, SeatDA>();
    UnityManager.Container.RegisterType<IShowDA, ShowDA>();
    UnityManager.Container.RegisterType<ITheatreDA, TheatreDA>();
    UnityManager.Container.RegisterType<IUserDA, UserDA>();

    UnityManager.Container.RegisterType<IBaseBL, BaseBL>();
    UnityManager.Container.RegisterType<ICinemaBL, CinemaBL.BL.CinemaBL>();
    UnityManager.Container.RegisterType<ICityBL, CityBL>();
    UnityManager.Container.RegisterType<IItemBL, ItemBL>();
    UnityManager.Container.RegisterType<IMovieBL, MovieBL>();
    UnityManager.Container.RegisterType<IReservationBL, ReservationBL>();
    UnityManager.Container.RegisterType<IRoomBL, RoomBL>();
    UnityManager.Container.RegisterType<ISeatBL, SeatBL>();
    UnityManager.Container.RegisterType<IShowBL, ShowBL>();
    UnityManager.Container.RegisterType<ITheatreBL, TheatreBL>();
    UnityManager.Container.RegisterType<IUserBL, UserBL>();
}

static void CreateEntity(out Cinema Cinema, out City City
                        , out Item Item, out Movie Movie, out Reservation Reservation
                        , out Room Room, out Seat Seat, out Show Show, out Theatre Theatre, out User User)
{
    Cinema = new Cinema()
    {

    };
    City = new City()
    {

    };
    Item = new Item()
    {

    };
    Movie = new Movie()
    {

    };
    Reservation = new Reservation()
    {

    };
    Room = new Room()
    {

    };
    Seat = new Seat()
    {

    };
    Show = new Show()
    {

    };
    Theatre = new Theatre()
    {

    };

    User = new User()
    {

    };

}
static void Resolve<T>() => UnityManager.Container.Resolve<T>();

static void UnityResolve(out ICinemaBL CinemaBL, out ICityBL CityBL, out IItemBL ItemBL,
                         out IMovieBL MovieBL, out IReservationBL ReservationBL, out IRoomBL RoomBL,
                         out ISeatBL SeatBL, out IShowBL ShowBL, out ITheatreBL TheatreBL, out IUserBL UserBL)
{
     CinemaBL = UnityManager.Container.Resolve<ICinemaBL>();
     CityBL = UnityManager.Container.Resolve<ICityBL>();
     ItemBL = UnityManager.Container.Resolve<IItemBL>();
     MovieBL = UnityManager.Container.Resolve<IMovieBL>();
     ReservationBL = UnityManager.Container.Resolve<IReservationBL>();
     RoomBL = UnityManager.Container.Resolve<IRoomBL>();
     SeatBL = UnityManager.Container.Resolve<ISeatBL>();
     ShowBL = UnityManager.Container.Resolve<IShowBL>();
     TheatreBL = UnityManager.Container.Resolve<ITheatreBL>();
     UserBL = UnityManager.Container.Resolve<IUserBL>();
}