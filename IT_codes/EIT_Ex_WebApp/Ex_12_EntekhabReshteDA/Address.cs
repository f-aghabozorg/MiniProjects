using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_1_TPH_EntekhabReshteDA
{
    [Table("Address")]
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string FullAddress { get; set; }
        public User User { get; set; }

    }
}
