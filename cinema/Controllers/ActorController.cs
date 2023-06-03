using dataacces.Data;
using dataacces.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly cinemadbcontext context;
        public ActorController(cinemadbcontext context)
        {
            this.context = context;
        }
        [HttpGet]                      
        
        public IActionResult Get()
        {
            return Ok(context.actors.ToList());
        }
        [HttpGet("details/{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0) return BadRequest();

            var actors = context.actors.Find(id);

            if (actors == null) return NotFound();

            return Ok(actors);
        }

        [HttpPost]
        public IActionResult Create(Actor actors)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.actors.Add(actors);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(Actor actors)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.actors.Update(actors);
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();

            var actors = context.actors.Find(id);

            if (actors == null) return NotFound();

            context.actors.Remove(actors);
            context.SaveChanges();

            return Ok();
        }
    }
}
