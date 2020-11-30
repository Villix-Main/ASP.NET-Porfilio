using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebAPI.Models
{
    public class CodeSnippet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public string Snippet { get; set; }

        public string SecretString { get; set; } = "This is a secret string";
    }
}
