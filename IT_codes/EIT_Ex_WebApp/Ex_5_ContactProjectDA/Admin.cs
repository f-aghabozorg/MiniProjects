using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5_ContactProjectDA
{
    public class Admin
    {
        public Admin()

        {

            List<User> Users = new List<User>();

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Gender { get; set; }

        public string PicturePath { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int Id { get; set; }

        public List<User> Users { get; set; }
    }
}
