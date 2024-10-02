using API_FARM.Models;
using Microsoft.EntityFrameworkCore;

namespace API_FARM.Data
{
    public class ApplicationDbContex : DbContext
    {

        public DbSet<AnimalType> AnimalTypes{ get; set; }
        
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options) { }
    }
}