using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_EntekhabReshteDA
{
    public class STCourse : IEntity
    {
        public int Id { get; set; }
        public int TCourseId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
