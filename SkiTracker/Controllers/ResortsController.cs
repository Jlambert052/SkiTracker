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
    public class ResortsController : ControllerBase
    {
        private readonly SkiTrackerDbContext _context;

        public ResortsController(SkiTrackerDbContext context)
        {
            _context = context;
        }

        // GET: api/Resorts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Resort>>> GetResorts()
        {
            return await _context.Resorts.ToListAsync();
        }

        // GET: api/Resorts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Resort>> GetResort(int id)
        {
            var resort = await _context.Resorts.FindAsync(id);

            if (resort == null)
            {
                return NotFound();
            }

            return resort;
        }

        // PUT: api/Resorts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResort(int id, Resort resort)
        {
            if (id != resort.Id)
            {
                return BadRequest();
            }

            _context.Entry(resort).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResortExists(id))
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

        // POST: api/Resorts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Resort>> PostResort(Resort resort)
        {
            _context.Resorts.Add(resort);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResort", new { id = resort.Id }, resort);
        }

        // DELETE: api/Resorts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResort(int id)
        {
            var resort = await _context.Resorts.FindAsync(id);
            if (resort == null)
            {
                return NotFound();
            }

            _context.Resorts.Remove(resort);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResortExists(int id)
        {
            return _context.Resorts.Any(e => e.Id == id);
        }
    }
}
