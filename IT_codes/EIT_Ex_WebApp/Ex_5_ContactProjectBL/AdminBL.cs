using Ex_5_ContactProjectDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5_ContactProjectBL
{
    public class AdminBL

    {
        #region Property
        private ContactContext context;

        public ContactContext Context
        {
            get
            {
                if (context == null)
                    context = new ContactContext();
                return context;
            }
            set { context = value; }
        }
        #endregion 

        public Admin Insert(string firstName, string lastName, bool Gender, string PicturePath, string Email, string Address, string Number)
        {


            Admin admin = new Admin();
            admin.Id = getAllAsQueryable().Any() ? getAllAsQueryable().Max(p => p.Id) + 1 : 1;
            admin.Address = Address;
            admin.Number = Number;
            admin.FirstName = firstName;
            admin.LastName = lastName;
            admin.Gender = Gender;
            admin.PicturePath = PicturePath;
            admin.Email = Email;
            Context.Admins.Add(admin);
            Context.SaveChanges();
            return admin;
        }
        #region Get
        private IQueryable<Admin> getAllAsQueryable()
        {
            return (from p in Context.Admins
                    select p);
        }
        #endregion

    }
}
