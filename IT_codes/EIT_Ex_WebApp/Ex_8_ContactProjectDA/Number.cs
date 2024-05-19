using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_ContactProjectDA
{
    public class Number : IEntity
    {
        public string PhoneNumber { get; set; }
        public byte Type { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
