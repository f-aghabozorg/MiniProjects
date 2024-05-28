﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class Cinema : ICinema
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }

        public City City { get; set; }
        public virtual ICollection<Room> Room { get; set; }


    }
}