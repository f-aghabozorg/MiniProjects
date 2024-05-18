using Ex_8_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8_ContactProjectBL
{
    public class AdminBL : BaseBL<Admin>

    {

        public Admin Insert(string firstName, string lastName, bool Gender, string PicturePath, string Email, string Address, string Number)
        {
            Admin admin = new Admin();
            admin.Address = Address;
            admin.Number = Number;
            admin.FirstName = firstName;
            admin.LastName = lastName;
            admin.Gender = Gender;
            admin.PicturePath = PicturePath;
            admin.Email = Email;
            return base.Insert(admin);
        }

    }
}
