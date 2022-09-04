using Microsoft.EntityFrameworkCore;
using AppContactosV1.Models;
 
namespace AppContactosV1.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        } 
        public DbSet<Contactos> Contactos {get; set;}
    }
}