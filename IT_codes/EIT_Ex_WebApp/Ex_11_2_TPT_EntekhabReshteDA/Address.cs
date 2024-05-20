using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_2_TPT_EntekhabReshteDA
{
    [Table("Address")]
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string FullAddress { get; set; }
        public User User { get; set; }

    }
}
