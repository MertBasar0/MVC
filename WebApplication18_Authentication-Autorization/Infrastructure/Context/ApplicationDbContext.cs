using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication18_Authentication_Autorization.Models.Entities.Concrete;

namespace WebApplication18_Authentication_Autorization.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbcontext):base(dbcontext)
        {

        }
    }
}
