using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_EntekhabReshteDA
{
    public class Teacher : User // : IEntity //
    {
        public int Id { get; set; }
        public byte MadrakType { get; set; }
        public int TeacherCode { get; set; }
        public virtual ICollection<TCourse> TCourse { get; set; }
        public User User { get; set; }
    }
}
