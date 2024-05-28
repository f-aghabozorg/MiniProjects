using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class Reservation:IReservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ShowId { get; set; }
        public int SeatId { get; set; }
        public bool IsCancell { get; set; }
        public decimal Price { get; set; }

        public User User { get; set; }
        public Show Show { get; set; }
        public Seat Seat { get; set; }
    }
}
