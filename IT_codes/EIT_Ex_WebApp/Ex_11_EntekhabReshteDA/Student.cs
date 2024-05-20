using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_EntekhabReshteDA
{
    [Table("Student")]
    public class Student : IEntity
    {
        [Required]
        public new int Id { get; set; }
        public int StudentCode { get; set; }
        public virtual ICollection<STCourse> STCourse { get; set; }
        public User User { get; set; }

    }
}
