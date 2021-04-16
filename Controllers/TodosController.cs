using Booking_taskApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaskApp_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly InitialContext _context;

        public TodosController(InitialContext context)
        {
            _context = context;
        }

        // GET: api/<Todos>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Todos.ToList());
        }

        // GET api/<Todos>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var todos = _context.Todos.FirstOrDefault(m => m.Id == id);
            if (todos == null)
                return NotFound();
            return Ok(todos);

        }

        
    }
}
