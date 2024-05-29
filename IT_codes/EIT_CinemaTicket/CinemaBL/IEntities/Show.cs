using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class Show : IEntity
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int RoomId { get; set; }
        public DateTime Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public Item Item { get; set; }
        public Room Room { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }

   
}
