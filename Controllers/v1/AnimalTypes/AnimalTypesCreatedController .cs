using API_FARM.Repositories;
using Microsoft.AspNetCore.Mvc;
using API_FARM.Models;
using Swashbuckle.AspNetCore.Annotations;


namespace API_FARM.Controllers.v1.AnimalTypes
{
    [ApiController]
    [Route("api/v1/Animal")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AnimalTypesCreatedController(IAnimalTypeRepository animalType) : AnimalTypesControllers(animalType)
    {
        [HttpPost("create")]
        [SwaggerOperation(
            Summary ="Create animal type",
            Description ="This method create animal type"
        )]
        [SwaggerResponse(200,"Animal was created succes")]
        [SwaggerResponse(400,"Data invalided")]
        
        public async Task<ActionResult<AnimalType>> Create(AnimalType animalType)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest("Los datos enviados no son correctos");
            }

            await _animalType.Create(animalType);
            return Ok(animalType);

        }

    }
}