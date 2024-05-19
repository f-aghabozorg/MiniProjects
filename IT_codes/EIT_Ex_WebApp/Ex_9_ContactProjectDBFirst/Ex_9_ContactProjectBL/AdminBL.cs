using Ex_9_ContactProjectDBFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9_ContactProjectBL
{
    public class AdminBL : BaseBL<Admins>

    {

        public Admins Insert(string firstName, string lastName, bool Gender, string PicturePath, string Email, string Address, string Number)
        {
            Admins admin = new Admins();
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
