using Microsoft.EntityFrameworkCore;
using WebApplication9_Odev.Models;

namespace WebApplication9_Odev.Dal
{
    public class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-AK0MLSE8; Database=Northwind; integrated security=True; MultipleActiveResultSets=True;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
