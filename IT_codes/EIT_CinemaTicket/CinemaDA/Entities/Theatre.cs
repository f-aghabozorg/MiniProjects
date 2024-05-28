using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class Theatre:Item,ITheatre
    {
        public int Id { get; set; }
        public int ItemId { get; set; }

        public Item Item { get; set; }

    }
}
