using API_FARM.Controllers.v1.AnimalTypes;
using API_FARM.Repositories;
using Microsoft.AspNetCore.Mvc;
using API_FARM.Models;

namespace API_FARM.Controllers.v1.AnimalTypes
{
    public class AnimalTypeGetController(IAnimalTypeRepository animalType) : AnimalTypesControllers(animalType)
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnimalType>>> GetAll()
        {
            var animals = await _animalType.GetAll();
            return Ok(animals);
        }

    }
}