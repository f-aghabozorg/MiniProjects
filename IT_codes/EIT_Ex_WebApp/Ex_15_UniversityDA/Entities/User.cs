using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_15_UniversityBL;

namespace Ex_15_UniversityDA
{
    public class User : Entity ,IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MobileNumber { get; set; }

    }
}
