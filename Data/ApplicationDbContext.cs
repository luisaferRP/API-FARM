using API_FARM.Models;
using Microsoft.EntityFrameworkCore;

namespace API_FARM.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<AnimalType> AnimalTypes{ get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}