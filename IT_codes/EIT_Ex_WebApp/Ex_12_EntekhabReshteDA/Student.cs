using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_1_TPH_EntekhabReshteDA
{
    [Table("Student")]
    public class Student : User
    {
    }
}
