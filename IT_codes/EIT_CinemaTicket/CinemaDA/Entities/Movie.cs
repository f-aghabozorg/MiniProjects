using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class Movie: Item, IMovie
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Genre { get; set; }
        public Item Item { get; set; }


    }
}
