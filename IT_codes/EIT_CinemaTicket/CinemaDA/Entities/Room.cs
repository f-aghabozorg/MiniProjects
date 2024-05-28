using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class Room:IRoom
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int RowCount { get; set; }
        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }

        public virtual ICollection<Show> Show { get; set; }
    }
}
