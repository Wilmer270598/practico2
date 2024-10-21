using Microsoft.EntityFrameworkCore;
using PRACTICA_2.Models;

namespace PRACTICA_2.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
    }
}
