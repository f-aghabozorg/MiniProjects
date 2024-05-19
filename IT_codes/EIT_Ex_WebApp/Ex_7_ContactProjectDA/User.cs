using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7_ContactProjectDA
{
    public class User
    {
        public User()
        {
            List<Number> Numbers = new List<Number>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string PicturePath { get; set; }
        public int Id { get; set; }
        public int AdminId { get; set; }
        public List<Number> Numbers { get; set; }
    }
}
