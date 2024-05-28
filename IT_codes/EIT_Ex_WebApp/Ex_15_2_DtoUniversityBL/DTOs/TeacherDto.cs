using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex_15_2_DtoUniversityBL
{
    public class TeacherDto: IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public int MadrakType { get; set; }
        public int TeacherCode { get; set; }
    }
}