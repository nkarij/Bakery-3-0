using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    // AppDbContext is the intermediate between our code and the database
    //required: inherit from the DbContext base class
    public class AppDbContext : DbContext
    {
        //required: an instance of DbContextOptions to be able to execute
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //required: DbSet to instruct which entity the Dbcontext is going to manage
        public DbSet<Pie> Pies { get; set; }

        // the database will be found by help of the connection string in appsettings.json

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed data
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieID = 1,
                Name = "Apple Pie",
                Price = 12.96M,
                ShortDescription = "Our famous apple pies",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieID = 2,
                Name = "Brownie",
                Price = 5.25M,
                ShortDescription = "Our famous Brownie",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieID = 3,
                Name = "Chery Pie",
                Price = 3.16M,
                ShortDescription = "Twin Peaks famous Cherry pies",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieID = 5,
                Name = "Othello Cake",
                Price = 112.96M,
                ShortDescription = "Our expensive Othello Cake",
            });
        }

    }
}
