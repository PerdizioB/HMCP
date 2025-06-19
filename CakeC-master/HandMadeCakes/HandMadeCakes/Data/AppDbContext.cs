
using HandMadeCakes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HandMadeCakes.Data
    {
    public class AppDbContext : IdentityDbContext<ApplicationUser>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }

        // Adicione outros DbSet se necessário
        public DbSet<CakeModel> Cake { get; set; }
    }






        
    
}