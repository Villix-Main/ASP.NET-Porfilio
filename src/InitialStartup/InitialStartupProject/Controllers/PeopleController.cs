using InitialProject.Models;
using InitialProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitialStartupProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private JsonFilePersonService _personService;

        public PeopleController(JsonFilePersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetPeople()
        {
            var people = _personService.GetPeople();
            return Ok(people);
        }

        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            var person = _personService.GetPeople().FirstOrDefault(x => x.Id == id);

            if (person == null)
                return NotFound();
            return Ok(person);
        }

        [HttpPost()]
        public ActionResult<Person> CreatePerson(Person person)
        {
            _personService.CreatePerson(person);
            return Ok(person);
        }
    }
}
