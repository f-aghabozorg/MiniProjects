using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_15_UniversityBL;

namespace Ex_15_UniversityDA
{
    public class Teacher  : Entity ,ITeacher
    {
        public int Id { get; set; }
        public byte MadrakType { get; set; }
        public int TeacherCode { get; set; }
    }
}
