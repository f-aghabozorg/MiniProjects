using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDA.Entities
{
    public class CinemaContext : DbContext
    {
        public CinemaContext() : base("BaseConnectionString")
        {



        }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Show> Show { get; set; }
        public DbSet<Theatre> Theatre { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
             .HasMany(e => e.Reservation)
             .WithRequired(e => e.User)
             .WillCascadeOnDelete(true);

            modelBuilder.Entity<Show>()
            .HasMany(e => e.Reservation)
            .WithRequired(e => e.Show)
            .WillCascadeOnDelete(true);

            modelBuilder.Entity<Room>()
          .HasMany(e => e.Show)
          .WithRequired(e => e.Room)
          .WillCascadeOnDelete(true);

            modelBuilder.Entity<Cinema>()
          .HasMany(e => e.Show)
          .WithRequired(e => e.Cinema)
          .WillCascadeOnDelete(true);

            modelBuilder.Entity<City>()
          .HasMany(e => e.Cinema)
          .WithRequired(e => e.City)
          .WillCascadeOnDelete(true);

            //TPC
            modelBuilder.Entity<Movie>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Movie");
            });

            modelBuilder.Entity<Theatre>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Theatre");
            });
        }
    }
}
