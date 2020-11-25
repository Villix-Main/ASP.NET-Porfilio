using InitialProject.Models;
using InitialProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitialStartupProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private JsonFilePersonService _personService;

        public IEnumerable<Person> People { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFilePersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public void OnGet()
        {
            People = _personService.GetPeople();
        }
    }
}
