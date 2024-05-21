using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13_IOCTextDA
{

    public class IOCTextContext : DbContext
    {
        public IOCTextContext() : base("TextIOCConnectionString")
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Forum> Forums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TXT");

        }
    }
}
