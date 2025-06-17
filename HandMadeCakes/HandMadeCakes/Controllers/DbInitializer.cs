using HandMadeCakes.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace HandMadeCakes.Controllers
{
    public class DbInitializer : IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly RoleManager<IdentityRole> _userManager;
        private readonly AppDbContext _context;

        public DbInitializer(RoleManager<IdentityRole> roleManager, RoleManager<IdentityRole> userManager, AppDbContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public async void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();

                }

            }
            catch (Exception)

            {
                throw;

            }

            if (_context.Roles.Any(x => x.Name == "Admin")) return;
            _roleManager.CreateAsync(new IdentityRole("Manager")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Customer")).GetAwaiter().GetResult();

            var user = new ApplicationUser()
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                FirstName = "Admin",
                City = "Stoke on Trent",
                Address = "9 HUMBERT ROAD",
                PostalCode = "ST1 5GA"
            };

        /*
       
            _userManager.CreateAsync(user, "Admin@123").GetAwaiter().GetResult();
            _userManager.CreateAsync(user, "Admin");


            */






        }

    }
    }

