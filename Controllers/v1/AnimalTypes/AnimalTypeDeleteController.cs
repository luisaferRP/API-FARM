using  API_FARM.Controllers.v1.AnimalTypes;
using API_FARM.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_FARM.Controllers.v1.AnimalTypes
{
    [ApiController]
    [Route("api/v1/Delete")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AnimalTypeDeleteControllers(IAnimalTypeRepository animalType) : AnimalTypesControllers(animalType)
    {
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Delete by id",
            Description ="This endpoint is for delete by id"
        )]
        [SwaggerResponse(200,"The data was delete")]
        [SwaggerResponse(400,"Data not deleted")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _animalType.Delete(id);
                return Ok();
            }
            catch
            {   
                return BadRequest("Ocurrio un error");
            }
        }
    }
}