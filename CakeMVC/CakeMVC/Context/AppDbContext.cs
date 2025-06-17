using CakeMVC.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CakeMVC.Context
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        {

        }
        public DbSet<Cake> Cakes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cake>().HasData(
               new Cake
               {
                   CakeId = 1,
                   Flavor = "Chocolate",
                   Cover = "",
                   Description = "Perfect cake",
                   Price = 20.5


               });

        }
                
        }

    }

