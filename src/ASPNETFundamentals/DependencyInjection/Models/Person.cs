using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Person
    {
        public int Id { get; init; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Person()
        {
            Id = new Random().Next(1, 15);
        }
    }
}
