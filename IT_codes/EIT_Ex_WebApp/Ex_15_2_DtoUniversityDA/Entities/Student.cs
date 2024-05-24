using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_15_2_DtoUniversityBL;


namespace Ex_15_2_DtoUniversityDA
{
    public class Student : User , IStudent
    {
        public new int Id { get; set; }
        public int StudentCode { get; set; }

    }
}
