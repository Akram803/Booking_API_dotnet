using Booking_taskApi.Data;
using Booking_taskApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApp_1.Controllers
{
    [Route("[controller]")]  
    [ApiController]
    public class SeedController : Controller
    {
        private readonly InitialContext _context;
        public SeedController(InitialContext context)
        {
            _context = context;
        }

        [HttpGet("todos")]
        public IActionResult todos()
        {

            Todos[] todoList = new Todos[] {
                new Todos(){ Title="delectus aut autem",                          Completed=false, CreatedAt=DateTime.Now },
                new Todos(){ Title="quis ut nam facilis et",          Completed=true, CreatedAt=DateTime.Now },
                new Todos(){ Title="fugiat veniam minus",                         Completed=false, CreatedAt=DateTime.Now },
                new Todos(){ Title="et porro tempora",                            Completed=true, CreatedAt=DateTime.Now },
                new Todos(){ Title="laboriosam mollitia et enim", Completed=true, CreatedAt=DateTime.Now },
                new Todos(){ Title="quibusdam voluptatem quia",             Completed=false, CreatedAt=DateTime.Now },
            };

            for (int i = 0; i < todoList.Length; i++)
                _context.Add(todoList[i]);
            _context.SaveChanges();

            return Ok("done!");
        }

        [HttpGet("notes")]
        public IActionResult notes()
        {
            List<Notes> notesList = new List<Notes>() { 
                new Notes(){ Title="delectus aut autem",    Description="Description Description Description DescriptionDescription Description  ",
                    CreatedAt=DateTime.Now },
                new Notes(){ Title="quis ut nam facilis et",Description="Description Description Description Description Description Description ", 
                    CreatedAt=DateTime.Now },
                new Notes(){ Title="fugiat veniam minus",   Description="Description Description Description Description Description Description ", 
                    CreatedAt=DateTime.Now },
                new Notes(){ Title="et porro tempora",      Description="Description Description Description Description Description Description ", 
                    CreatedAt=DateTime.Now },
                new Notes(){ Title="quibusdam voluptatem",  Description="Description Description Description Description Description Description ", 
                    CreatedAt=DateTime.Now },
                new Notes(){ Title="laboriosam mollitia",   Description="Description Description Description Description Description Description ", 
                    CreatedAt=DateTime.Now },
            };

            //notesList.ForEach((n) => { _context.ad });
            _context.AddRange(notesList);
            _context.SaveChanges();

            return Ok("done!");
        }

        [HttpGet("contacts")]
        public IActionResult contacts()
        {
            List<Contacts> data = new List<Contacts>() {
                new Contacts(){ Name="Aka",     Mail="Aka@app.fake" },
                new Contacts(){ Name="Adam",    Mail="Adam@app.fake" },
                new Contacts(){ Name="Mr Dark", Mail="Dark@app.fake" },
                new Contacts(){ Name="Mr Code", Mail="ocme@app.fake" },
                new Contacts(){ Name="Essra",   Mail="Essra@app.fake" },
            };

            _context.AddRange(data);
            _context.SaveChanges();

            return Ok("done!");
        }

        [HttpGet("events")]
        public IActionResult events()
        {
            List<Events> data = new List<Events>() {
                new Events(){ Title="discution",        Date=DateTime.Parse("2021-04-14")  },
                new Events(){ Title="meeting",          Date=DateTime.Parse("2021-04-16")  },
                new Events(){ Title="party",            Date=DateTime.Parse("2021-04-18")  },
                new Events(){ Title="event AA",    Date=DateTime.Parse("2021-04-22")  },
                new Events(){ Title="event BB",    Date=DateTime.Parse("2021-04-26")  },
            };

            _context.AddRange(data);
            _context.SaveChanges();

            return Ok("done!");
        }

    }
}
