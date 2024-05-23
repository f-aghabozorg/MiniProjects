using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_IOCTextDA
{
    [Table("News")]
    public class News : IEntity
    {
        public int Id { get; set; }
        public string HeadLine { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }
        public string Reporter { get; set; }
    }
}