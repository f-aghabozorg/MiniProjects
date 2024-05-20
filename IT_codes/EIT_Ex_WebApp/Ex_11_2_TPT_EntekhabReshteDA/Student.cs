using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_2_TPT_EntekhabReshteDA
{
    [Table("Student")]
    public class Student : User
    {
        [Required]
        public int StudentCode { get; set; }
        public virtual ICollection<STCourse> STCourse { get; set; }

    }
}
