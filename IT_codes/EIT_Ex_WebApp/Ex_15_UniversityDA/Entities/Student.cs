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
    public class Student : User , IStudent
    {
        public new int Id { get; set; }
        public int StudentCode { get; set; }

    }
}
