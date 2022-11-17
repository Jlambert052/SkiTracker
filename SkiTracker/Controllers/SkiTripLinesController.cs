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
    public class SkiTripLinesController : ControllerBase
    {
        private readonly SkiTrackerDbContext _context;

        public SkiTripLinesController(SkiTrackerDbContext context)
        {
            _context = context;
        }

        // GET: api/SkiTripLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkiTripLine>>> GetSkiTripLines()
        {
            return await _context.SkiTripLines.ToListAsync();
        }

        // GET: api/SkiTripLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkiTripLine>> GetSkiTripLine(int id)
        {
            var skiTripLine = await _context.SkiTripLines.FindAsync(id);

            if (skiTripLine == null)
            {
                return NotFound();
            }

            return skiTripLine;
        }

        // PUT: api/SkiTripLines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkiTripLine(int id, SkiTripLine skiTripLine)
        {
            if (id != skiTripLine.Id)
            {
                return BadRequest();
            }

            _context.Entry(skiTripLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkiTripLineExists(id))
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

        // POST: api/SkiTripLines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkiTripLine>> PostSkiTripLine(SkiTripLine skiTripLine)
        {
            _context.SkiTripLines.Add(skiTripLine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSkiTripLine", new { id = skiTripLine.Id }, skiTripLine);
        }

        // DELETE: api/SkiTripLines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkiTripLine(int id)
        {
            var skiTripLine = await _context.SkiTripLines.FindAsync(id);
            if (skiTripLine == null)
            {
                return NotFound();
            }

            _context.SkiTripLines.Remove(skiTripLine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkiTripLineExists(int id)
        {
            return _context.SkiTripLines.Any(e => e.Id == id);
        }
    }
}
