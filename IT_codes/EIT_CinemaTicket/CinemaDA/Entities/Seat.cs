using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class Seat:ISeat
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int Number { get; set; }

    }
}
