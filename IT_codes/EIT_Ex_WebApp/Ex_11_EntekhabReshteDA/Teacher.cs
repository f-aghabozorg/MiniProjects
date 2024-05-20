using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_EntekhabReshteDA
{
    [Table("Teacher")]
    public class Teacher  : IEntity //
    {
        public new int Id { get; set; }
        public byte MadrakType { get; set; }
        public int TeacherCode { get; set; }
        public virtual ICollection<TCourse> TCourse { get; set; }
        public User User { get; set; }
    }
}
