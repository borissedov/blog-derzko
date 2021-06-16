using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CustomIdentityApp.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}