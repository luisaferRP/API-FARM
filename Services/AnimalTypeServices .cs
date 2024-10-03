using API_FARM.Repositories;
using API_FARM.Models;
using Microsoft.EntityFrameworkCore;
using API_FARM.Data;

namespace API_FARM.Services
{
    public class AnimalTypeServices : IAnimalTypeRepository
    {
        //using database
        private readonly ApplicationDbContext _context;

        public AnimalTypeServices (ApplicationDbContext context)
        {
            _context = context;   
        }

        public async Task<IEnumerable<AnimalType>> GetAll()
        {
            return await _context.AnimalTypes.ToListAsync();
        }
        
    }
}