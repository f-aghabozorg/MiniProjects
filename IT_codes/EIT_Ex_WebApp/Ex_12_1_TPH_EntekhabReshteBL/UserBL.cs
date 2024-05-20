using Ex_12_1_TPH_EntekhabReshteDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_1_TPH_EntekhabReshteBL
{
    public class UserBL : BaseBL<User>
    {
        public User Insert(string fName, string lname, string mobileNumber)
        {
            return base.Insert(new User
            {
                FirstName = fName,
                LastName = lname,
                MobileNumber = mobileNumber
            });
        }
    }
}
