using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CustomIdentityApp.Models
{
    public class DbContext : IdentityDbContext<User>
    {
        public DbContext(DbContextOptions<DbContext> options)
            : base(options);


    }

    static ApplicationDbContext()
    {
        Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
    }

    public static ApplicationDbContext Create()
    {
        return new ApplicationDbContext();
    }
        {
internal class ApplicationDbContext
    {
        public ApplicationDbContext()
        {
        }
    }

    Database.EnsureCreated();
        }
    }
}
