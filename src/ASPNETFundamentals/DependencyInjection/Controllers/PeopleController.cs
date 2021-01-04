using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private Person _person;

        public PeopleController(Person person)
        {
            _person = person;
        }
        
        [HttpGet]
        public ActionResult<Person> GetPerson() => Ok(_person);
    }
}
