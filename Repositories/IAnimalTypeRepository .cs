using API_FARM.Models;

namespace API_FARM.Repositories
{
    public interface IAnimalTypeRepository 
    {
         Task<IEnumerable<AnimalType>> GetAll();
    }
}