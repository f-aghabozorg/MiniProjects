using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15_UniversityDA
{
    public class UniversityContext:DbContext
    {
        public UniversityContext() : base("BaseConnectionString")
        {



        }

        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
