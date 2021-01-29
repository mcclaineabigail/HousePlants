
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HousePlants.Data.EFCore;
using HousePlants.Models;
using HousePlants.Controllers;

namespace HousePlants
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : HousePlantsController<Plant, EfCorePlantRepository>
    {
        public PlantController(EfCorePlantRepository repository) : base(repository)
        {

        }
    }
}
