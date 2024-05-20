using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_2_TPT_EntekhabReshteDA
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
        public Address Address { get; set; }

    }
}
