using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousePlants.Data;


namespace HousePlants.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class HousePlantsController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public HousePlantsController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var plant = await repository.Get(id);
            if (plant == null)
            {
                return NotFound();
            }
            return plant;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity Plant)
        {
            if (id != Plant.Id)
            {
                return BadRequest();
            }
            await repository.Update(Plant);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity plant)
        {
            await repository.Add(plant);
            return CreatedAtAction("Get", new { id = plant.Id }, plant);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var plant = await repository.Delete(id);
            if (plant == null)
            {
                return NotFound();
            }
            return plant;
        }

    }
}

