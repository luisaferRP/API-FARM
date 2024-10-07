using API_FARM.Models;
using Microsoft.EntityFrameworkCore;
using API_FARM.Seeders;

namespace API_FARM.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<AnimalType> AnimalTypes{ get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //esto es para creacion de seeders
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            AnimalTypeSeeder.Seed(modelBuilder);
        }
    }
}