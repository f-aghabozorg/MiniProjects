using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_ContactProjectDA
{
    public class Admin : IEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string PicturePath { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
