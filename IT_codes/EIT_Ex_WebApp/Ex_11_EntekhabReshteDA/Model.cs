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

namespace Ex_11_EntekhabReshteDA
{
    public class Model
    {

        public partial class EntekhabReshteCotext : DbContext
        {
            public EntekhabReshteCotext()
            : base("name=MyConnectionString")
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

                modelBuilder.Entity<Teacher>()
                .HasMany(e => e.TCourse)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(true);

                modelBuilder.Entity<Student>()
                 .HasMany(e => e.STCourse)
                 .WithRequired(e => e.Student)
                 .WillCascadeOnDelete(false);

                modelBuilder.Entity<TCourse>()
                .HasMany(e => e.STCourse)
                .WithRequired(e => e.TCourse)
                .WillCascadeOnDelete(false);


                modelBuilder.Entity<User>()
                 .HasOptional(p => p.Teacher)
                 .WithRequired(p => p.User);

                modelBuilder.Entity<User>()
               .HasOptional(p => p.Student)
               .WithRequired(p => p.User);

                modelBuilder.Entity<User>()
                .HasOptional(p => p.Address)
                .WithRequired(p => p.User);

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