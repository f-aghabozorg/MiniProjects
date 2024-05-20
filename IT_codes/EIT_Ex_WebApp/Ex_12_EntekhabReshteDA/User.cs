using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_1_TPH_EntekhabReshteDA
{
    [Table("User")]
    public class User : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(256)]
        public string LastName { get; set; }


        [Required]
        [StringLength(256)]
        public string MobileNumber { get; set; }

        [NotMapped]
        public bool IsStudent { get; set; }
        public int Code { get; set; }
        public byte MadrakType { get; set; }

        public virtual ICollection<STCourse> STCourse { get; set; }
        public virtual ICollection<TCourse> TCourse { get; set; }

        public Address Address { get; set; }

    }
}
