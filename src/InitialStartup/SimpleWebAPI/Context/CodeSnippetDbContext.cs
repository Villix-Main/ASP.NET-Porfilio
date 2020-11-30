using Microsoft.EntityFrameworkCore;
using SimpleWebAPI.Models;

namespace SimpleWebAPI.Context
{
    public class CodeSnippetDbContext : DbContext
    {
        public CodeSnippetDbContext(DbContextOptions<CodeSnippetDbContext> options) 
            : base(options) { }

        public DbSet<CodeSnippet> Snippets { get; set; }
    }
}
