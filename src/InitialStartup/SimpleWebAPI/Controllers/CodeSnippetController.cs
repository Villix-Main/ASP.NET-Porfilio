    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleWebAPI.Context;
using SimpleWebAPI.Models;
using SimpleWebAPI.Models.DTO;

namespace SimpleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeSnippetController : ControllerBase
    {
        private readonly CodeSnippetDbContext _context;

        public CodeSnippetController(CodeSnippetDbContext context)
        {
            _context = context;
        }

        // GET: api/CodeSnippets
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<CodeSnippetDto>>> GetSnippets()
        {
            return await _context.Snippets
                .Select(x => ItemToDto(x))
                .ToListAsync();
        }

        // GET: api/CodeSnippets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CodeSnippetDto>> GetCodeSnippet(int id)
        {
            var codeSnippet = await _context.Snippets.FindAsync(id);

            if (codeSnippet == null)
            {
                return NotFound();
            }

            return ItemToDto(codeSnippet);
        }

        // PUT: api/CodeSnippets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCodeSnippet(int id, CodeSnippetDto codeSnippet)
        {
            if (id != codeSnippet.Id)
            {
                return BadRequest();
            }

            _context.Entry(codeSnippet).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeSnippetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CodeSnippets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CodeSnippetDto>> PostCodeSnippet(CodeSnippetDto codeSnippet)
        {
            var newSnippet = new CodeSnippet
            {
                Name = codeSnippet.Name,
                Language = codeSnippet.Language,
                Snippet = codeSnippet.Snippet
            };

            _context.Snippets.Add(newSnippet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCodeSnippet", new { id = codeSnippet.Id }, codeSnippet);
        }
        
        // DELETE: api/CodeSnippets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCodeSnippet(int id)
        {
            var codeSnippet = await _context.Snippets.FindAsync(id);
            if (codeSnippet == null)
            {
                return NotFound();
            }

            _context.Snippets.Remove(codeSnippet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CodeSnippetExists(int id)
        {
            return _context.Snippets.Any(e => e.Id == id);
        }

        private static CodeSnippetDto ItemToDto(CodeSnippet snippet) =>
            new CodeSnippetDto
            {
                Id = snippet.Id,
                Name = snippet.Language,
                Language = snippet.Language,
                Snippet = snippet.Snippet
            };
    }
}
