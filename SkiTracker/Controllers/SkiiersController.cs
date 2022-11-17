using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkiTracker.Models;

namespace SkiTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkiiersController : ControllerBase
    {
        private readonly SkiTrackerDbContext _context;

        public SkiiersController(SkiTrackerDbContext context)
        {
            _context = context;
        }

        // GET: api/Skiiers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Skiier>>> GetSkiiers()
        {
            return await _context.Skiiers.ToListAsync();
        }

        // GET: api/Skiiers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Skiier>> GetSkiier(int id)
        {
            var skiier = await _context.Skiiers.FindAsync(id);

            if (skiier == null)
            {
                return NotFound();
            }

            return skiier;
        }
        // GET: api/Skiiers/email/password
        [HttpGet("{email}/{password}")]
        public async Task<ActionResult<Skiier>> GetLogin(string email, string password) {
            var skiier = await _context.Skiiers.SingleOrDefaultAsync(x => x.Email == email && x.Password == password);

            if(skiier is null) {
                return NotFound();
            }
            return skiier;
        }

        // PUT: api/Skiiers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkiier(int id, Skiier skiier)
        {
            if (id != skiier.Id)
            {
                return BadRequest();
            }

            _context.Entry(skiier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkiierExists(id))
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

        // POST: api/Skiiers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Skiier>> PostSkiier(Skiier skiier)
        {
            _context.Skiiers.Add(skiier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSkiier", new { id = skiier.Id }, skiier);
        }

        // DELETE: api/Skiiers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkiier(int id)
        {
            var skiier = await _context.Skiiers.FindAsync(id);
            if (skiier == null)
            {
                return NotFound();
            }

            _context.Skiiers.Remove(skiier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkiierExists(int id)
        {
            return _context.Skiiers.Any(e => e.Id == id);
        }
    }
}
