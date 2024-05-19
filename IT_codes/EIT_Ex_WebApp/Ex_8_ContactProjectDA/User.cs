using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_ContactProjectDA
{
    public class User : IEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string PicturePath { get; set; }
        public int Id { get; set; }
        public int AdminId { get; set; }
        public ICollection<Number> Numbers { get; set; }

    }
}
