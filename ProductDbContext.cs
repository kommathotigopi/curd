using CRUD_CF.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_CF
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Products> products { get; set; }

        public ProductDbContext(DbContextOptions options):base (options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-9390DJ5\\SQLEXPRESS; Database=CRUDDb;integrated security=True;TrustServerCertificate=true;");
        //}
    }
    }

