
using Ex_9_ContactProjectDBFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9_ContactProjectBL
{
    public class NumberBL : BaseBL<Numbers>
    {

        public Numbers Insert(string phoneNumber, byte type, int userId)
        {

            Numbers number = new Numbers();
            number.PhoneNumber = phoneNumber;
            number.Type = type;
            number.UserId = userId;
            return base.Insert(number);
        }

        public List<Numbers> Insert(List<Numbers> Numbers)
        {
            foreach (Numbers number in Numbers)
            {
                base.Insert(number);
            }
            return Numbers;
        }

    }
}
