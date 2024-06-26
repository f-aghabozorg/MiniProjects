﻿using CinemaCMN;
using CinemaBL.BL;
using CinemaBL.IRepository;
using CinemaBL.IBL;
using CinemaDA.Repository;
using CinemaDA.Entities;
using Unity;
using static CinemaDA.Entities.Item;
using EIT_Cinema;
using System.Globalization;

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
                , CinemaBL, CityBL, ItemBL, ReservationBL
                , RoomBL, SeatBL, ShowBL, UserBL);

Console.WriteLine("Insert Completed!");

///////////////////////////////////////////////////////////////////////////////////////////////////

DateTime StartDate = DateTime.Parse("2024-05-01", CultureInfo.InvariantCulture);
DateTime EndDate = DateTime.Parse("2024-05-29", CultureInfo.InvariantCulture);
string CinemaName = "Cinema Azadi";
DateTime Date = DateTime.Parse("2024-05-29", CultureInfo.InvariantCulture);
string MovieTitle = "Texas-3";


//چند نفر امروز رزرو کرده اند؟
int CountTodayReservation = ReservationBL.CountTodayReservation();

//از تاریخ فلان تا فلان چند نفر رزرو کرده اند؟
int CountDateToDateReservation = ReservationBL.CountDateToDateReservation(StartDate, EndDate);

//برای سینمای مشخصی از تاریخ فلان تا فلان چند نفر رزرو کرده اند؟
int CountDateToDateReservationForCinema = ReservationBL.CountDateToDateReservationForCinema(StartDate, EndDate, CinemaName);

//از تاریخ فلان تا فلان چند نفر لغو کرده اند؟
int CountCancellDateToDateReservation = ReservationBL.CountCancellDateToDateReservation(StartDate, EndDate);

//برای یک سینمای مشخص در فلان روز سانس ها در چه ساعاتی هست؟
var ShowTimeListForCinema = ShowBL.ShowTimeListForCinema(CinemaName, Date);

//برای یک فیلم مشخص چه سینماهایی در چه سانس هایی این فیلم اکران میشود؟
var ShowListMovieForCinema = ShowBL.ShowListMovieForCinema(MovieTitle);

Console.WriteLine("Query Filters Completed!");


///////////////////////////////////////////////////////////////////////////////////////////////////