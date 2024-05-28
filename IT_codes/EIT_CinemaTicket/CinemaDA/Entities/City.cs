using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class City: ICity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Cinema> Cinema { get; set; }


    }
}
