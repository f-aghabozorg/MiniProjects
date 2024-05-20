using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_EntekhabReshteDA
{
    [Table("TCourse")]
    public class TCourse : IEntity
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public virtual ICollection<STCourse> STCourse { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }

    }
}
