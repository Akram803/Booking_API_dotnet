using Booking_taskApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Booking_taskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly InitialContext _context;

        public NotesController(InitialContext conxt)
        {
            _context = conxt;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Notes.ToList());
        }

        // GET api/<NotesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var note = _context.Notes.FirstOrDefault(m => m.Id == id);

            if (note == null)
                return NotFound();

            return Ok(note);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
