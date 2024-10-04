using API_FARM.Models;

namespace API_FARM.Repositories
{
    public interface IAnimalTypeRepository 
    {
         Task<IEnumerable<AnimalType>> GetAll();

         Task Create(AnimalType animalType);

         Task Delete(int id);

         Task<IEnumerable<AnimalType>> CheckeExistenById(int id);
    }
}