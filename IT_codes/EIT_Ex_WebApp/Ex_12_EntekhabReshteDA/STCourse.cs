using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_1_TPH_EntekhabReshteDA
{
    [Table("STCourse")]
    public class STCourse : IEntity
    {
        public int Id { get; set; }
        public int TCourseId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public TCourse TCourse { get; set; }
    }
}
