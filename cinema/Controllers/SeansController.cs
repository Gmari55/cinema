using dataacces.Data;
using dataacces.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeansController : ControllerBase
    {
        private readonly cinemadbcontext context;
        public SeansController(cinemadbcontext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.seans.ToList());
        }
        // GET api/<seans>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0) return BadRequest();

            var seans = context.seans.Find(id);

            if (seans == null) return NotFound();

            return Ok(seans);
        }
        [HttpPost]
        public IActionResult Create(Seans seans)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.seans.Add(seans);
            context.SaveChanges();

            return Ok();
            }

       

        // PUT api/<seans>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<seans>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
