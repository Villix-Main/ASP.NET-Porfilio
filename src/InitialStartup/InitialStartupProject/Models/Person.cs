using System.Text.Json;

namespace InitialProject.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int YearsOfExperience { get; set; }

        public bool IsMale { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}