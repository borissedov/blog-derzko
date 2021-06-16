using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CustomIdentityApp.Models
{
    public class User : IdentityUser
    {
        private DbContextOptions<DbContext> options;

        public User()
        {
        }

        public User(DbContextOptions<DbContext> options)
        {
            this.options = options;
        }

        public int Year { get; set; }
    }
}