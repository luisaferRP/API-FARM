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
        [SwaggerResponse(400,"No hay datos agregados")]
        public async Task<ActionResult<IEnumerable<AnimalType>>> GetAll()
        {
            var animals = await _animalType.GetAll();
            if (animals.Any() == false)
            {
                return NoContent(); 
            }
            return Ok(animals);
        }

        [HttpGet("Search")]
        [SwaggerOperation(
            Summary ="Search by id",
            Description = "This is endpoint is for search by id"
        )]
        [SwaggerResponse(200,"existence of data by id",typeof(AnimalType))]
        [SwaggerResponse(204,"the data for the id was not found")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult> CheckeExisten(int id)
        {
            var foundAnimalById = await _animalType.CheckeExistenById(id);

            if (foundAnimalById == null)
            {
                return NoContent();
            }
            return Ok(foundAnimalById);
        }
    }
}