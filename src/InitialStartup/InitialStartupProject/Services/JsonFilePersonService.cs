using InitialProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace InitialProject.Services
{
    public class JsonFilePersonService
    {
        public JsonFilePersonService(IWebHostEnvironment environment)
        {
            WebHostEnvironment = environment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "people.json");

        public IEnumerable<Person> GetPeople()
        {
            using var jsonReader = File.OpenText(JsonFileName);

            return JsonSerializer.Deserialize<Person[]>(jsonReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

        }

        public void CreatePerson(Person person)
        {
            var people = GetPeople();

            if (people.Count(x => x.Id == person.Id) > 0)
            {
                person.Id = people.Max(x => x.Id) + 1;
            }

            using var jsonWriter = File.OpenWrite(JsonFileName);

            JsonSerializer.Serialize(
                new Utf8JsonWriter(jsonWriter, new JsonWriterOptions
                {
                    SkipValidation = true,
                    Indented = true
                }),
                people.Append(person)
            );
            

  
         }
    }
}