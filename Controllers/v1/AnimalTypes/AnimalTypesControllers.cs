using API_FARM.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_FARM.Controllers.v1.AnimalTypes
{
    [ApiController]
    public class AnimalTypesControllers(IAnimalTypeRepository animalType) : ControllerBase
    {
        protected readonly IAnimalTypeRepository _animalType = animalType;
    }
}