using API_FARM.Repositories;
using API_FARM.Models;
using Microsoft.EntityFrameworkCore;
using API_FARM.Data;
using Microsoft.AspNetCore.Http.HttpResults;

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

        public async Task Create(AnimalType animalType)
        {
            if (animalType == null)
            {
                throw new ArgumentNullException(nameof(animalType) , "El tipo de animal no puede ser nulo");
            }
            try
            {
                 await _context.AnimalTypes.AddAsync(animalType);
                 await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Ups! ocurrio un error : ",ex);
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                var foundAnimal = await CheckeExistenById(id);
                
                if (foundAnimal.Any())
                {
                    try
                    {
                        //delete firts element found
                        _context.AnimalTypes.Remove(foundAnimal.First());
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"ups! hubo un error {ex.Message}");
                    }
                }
            }
            catch (Exception e)
            {   
                throw new Exception($"Ups,hubo un error {e.Message}");
            }
          
        }

        public async Task<IEnumerable<AnimalType>> GetAll()
        {
            return await _context.AnimalTypes.ToListAsync();
        }

        public async Task<IEnumerable<AnimalType>> CheckeExistenById(int id)
        {
            try
            {
                var foundAnimal = await _context.AnimalTypes.Where(d => d.Id == id).ToListAsync();

                return foundAnimal;
            }
            catch (Exception ex)
            {
                throw new Exception("Ups! Ocurrio un error",ex);
            }
        }
    }
}