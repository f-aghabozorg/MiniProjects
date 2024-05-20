using Ex_12_1_TPH_EntekhabReshteDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12_1_TPH_EntekhabReshteBL
{
    public class StudentBL : BaseBL<Student>
    {
        public Student Insert(string fName, string lname, string mobileNumber, int sCode)
        {
            return base.Insert(new Student
            {
                FirstName = fName,
                LastName = lname,
                MobileNumber = mobileNumber,
                Code = sCode
            });
        }
    }
}
