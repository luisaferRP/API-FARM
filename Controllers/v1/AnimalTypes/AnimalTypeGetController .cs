using API_FARM.Repositories;
using Microsoft.AspNetCore.Mvc;
using API_FARM.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace API_FARM.Controllers.v1.AnimalTypes
{
    [ApiController]
    [Route("api/v1/Animal")]
    public class AnimalTypeGetController(IAnimalTypeRepository animalType) : AnimalTypesControllers(animalType)
    {
        [HttpGet]
        [SwaggerOperation(
            Summary ="Get all animals",
            Description ="This is endpoint get all the animals"
        )]
        [SwaggerResponse(200,"Operations succes",typeof(IEnumerable<AnimalType>))]
        public async Task<ActionResult<IEnumerable<AnimalType>>> GetAll()
        {
            var animals = await _animalType.GetAll();
            if (animals.Any() == false)
            {
                return NoContent(); 
            }
            return Ok(animals);
        }

    }
}