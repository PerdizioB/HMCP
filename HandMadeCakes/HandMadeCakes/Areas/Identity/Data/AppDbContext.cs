using HandMadeCakes.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;



namespace HandMadeCakes.Areas.Identity.Data
{
    //SQL
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
          base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        public DbSet<CakeModel> Cake { get; set; }
    }
}