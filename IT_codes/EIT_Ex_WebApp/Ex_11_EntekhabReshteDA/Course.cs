using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_EntekhabReshteDA
{
    [Table("Course")]
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TCourse> TCourse { get; set; }

    }
}
