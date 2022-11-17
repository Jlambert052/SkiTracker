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
    public class RunsController : ControllerBase
    {
        private readonly SkiTrackerDbContext _context;

        public RunsController(SkiTrackerDbContext context)
        {
            _context = context;
        }

        // GET: api/Runs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Run>>> GetRuns()
        {
            return await _context.Runs.ToListAsync();
        }

        // GET: api/Runs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Run>> GetRun(int id)
        {
            var run = await _context.Runs.FindAsync(id);

            if (run == null)
            {
                return NotFound();
            }

            return run;
        }

        // PUT: api/Runs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRun(int id, Run run)
        {
            if (id != run.Id)
            {
                return BadRequest();
            }

            _context.Entry(run).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RunExists(id))
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

        // POST: api/Runs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Run>> PostRun(Run run)
        {
            _context.Runs.Add(run);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRun", new { id = run.Id }, run);
        }

        // DELETE: api/Runs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRun(int id)
        {
            var run = await _context.Runs.FindAsync(id);
            if (run == null)
            {
                return NotFound();
            }

            _context.Runs.Remove(run);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RunExists(int id)
        {
            return _context.Runs.Any(e => e.Id == id);
        }
    }
}
