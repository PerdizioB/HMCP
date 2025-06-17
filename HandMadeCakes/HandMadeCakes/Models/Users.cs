using Microsoft.AspNetCore.Identity;

namespace HandMadeCakes.Models
{
    public class Users : IdentityUser
    {
         
        public string FullName { get; set; }
    }
}