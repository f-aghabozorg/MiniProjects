using Ex_11_2_TPT_EntekhabReshteDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11_2_TPT_EntekhabReshteBL
{
    public class TeacherBL : BaseBL<Teacher>
    {
        public Teacher Insert(string fName, string lname, string mobileNumber)
        {
            return base.Insert(new Teacher
            {
                FirstName = fName,
                LastName = lname,
                MobileNumber = mobileNumber,
            });
        }
    }
}
