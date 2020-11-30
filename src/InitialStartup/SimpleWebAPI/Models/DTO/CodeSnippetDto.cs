using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebAPI.Models.DTO
{
    public class CodeSnippetDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public string Snippet { get; set; }
    }
}
