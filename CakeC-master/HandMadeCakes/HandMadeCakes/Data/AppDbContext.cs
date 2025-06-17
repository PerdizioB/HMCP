using HandMadeCakes.Models;
using Microsoft.EntityFrameworkCore;

namespace HandMadeCakes.Data
{
    //SQL
  public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<CakeModel> Cake { get; set; }
    }
}