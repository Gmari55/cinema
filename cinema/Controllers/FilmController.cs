using dataacces.Data;
using dataacces.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly cinemadbcontext context;
        public FilmController(cinemadbcontext context)
        {
            this.context = context;
        }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(context.films.ToList());
        }
        [HttpGet("details/{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0) return BadRequest();

            var films = context.films.Find(id);

            if (films == null) return NotFound();

            return Ok(films);
        }

        [HttpPost]
        public IActionResult Create(Film films)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.films.Add(films);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(Film films)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.films.Update(films);
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();

            var films = context.films.Find(id);

            if (films == null) return NotFound();

            context.films.Remove(films);
            context.SaveChanges();

            return Ok();
        }
    }
}

