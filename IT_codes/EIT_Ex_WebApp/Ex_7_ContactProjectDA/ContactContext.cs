using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7_ContactProjectDA
{
    public class ContactContext:DbContext
    {

        public ContactContext():base("ContactConnectionString")
        {

          

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Number> Numbers { get; set; }
    }
}
