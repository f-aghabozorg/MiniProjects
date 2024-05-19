using Ex_8_ContactProjectBL;
using Ex_8_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_ContactProjectBL
{
    public class NumberBL:BaseBL<Number>
    {

        public Number Insert(string phoneNumber, byte type, int userId)
        {

            Number number = new Number();
            number.PhoneNumber = phoneNumber;
            number.Type = type;
            number.UserId = userId;
            return base.Insert(number);
        }

        public List<Number> Insert(List<Number> Numbers)
        {
            foreach (Number number in Numbers)
            {
                base.Insert(number);
            }
            return Numbers;
        }
        
    }
}
