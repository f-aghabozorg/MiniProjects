using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class Item: IItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public Item_Type ItemType { get; set; }
        public enum Item_Type
        {
            Movie,
            Theatre
        }
    }
}
