using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace Ex_12_1_TPH_EntekhabReshteDA
{
    public class Model
    {

        public partial class EntekhabReshteContext : DbContext
        {
            public EntekhabReshteContext()
            : base("name=TPH_ConnectionString")
            {

            }

            public virtual DbSet<Course> Course { get; set; }

            public virtual DbSet<STCourse> STCourse { get; set; }

            public virtual DbSet<Student> Student { get; set; }

            public virtual DbSet<TCourse> TCourse { get; set; }

            public virtual DbSet<Teacher> Teacher { get; set; }

            public virtual DbSet<User> User { get; set; }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {


                modelBuilder.HasDefaultSchema("EDU");
                //modelBuilder.Entity<Student>().ToTable("Students");

                modelBuilder.Entity<Course>()
                .HasMany(e => e.TCourse)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(true);

                modelBuilder.Entity<User>()
                .HasMany(e => e.TCourse)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(true);

                modelBuilder.Entity<User>()
                 .HasMany(e => e.STCourse)
                 .WithRequired(e => e.Student)
                 .WillCascadeOnDelete(false);

                modelBuilder.Entity<TCourse>()
                .HasMany(e => e.STCourse)
                .WithRequired(e => e.TCourse)
                .WillCascadeOnDelete(false);


                modelBuilder.Entity<User>()
                 .Map<Teacher>(m => m.Requires("UserType").HasValue(0)) //discriminatorColumn: userType , discriminatorValue = 0
                 .Map<Student>(m => m.Requires("UserType").HasValue(1));

                modelBuilder.Entity<User>()
                .HasOptional(p => p.Address)
                .WithRequired(p => p.User);

                //TPC
                //modelBuilder.Entity<Student>().Map(m =>
                //{
                //    m.MapInheritedProperties();
                //    m.ToTable("Student");
                //});

                //modelBuilder.Entity<Teacher>().Map(m =>
                //{
                //    m.MapInheritedProperties();
                //    m.ToTable("Teacher");
                //});
            }

        }
    }
}