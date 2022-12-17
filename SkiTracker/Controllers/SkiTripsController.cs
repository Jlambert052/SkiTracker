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
    public class SkiTripsController : ControllerBase
    {
        private readonly SkiTrackerDbContext _context;

        public SkiTripsController(SkiTrackerDbContext context)
        {
            _context = context;
        }

        //Private: Recalculate functionality.
        private async Task<ActionResult>  RecalcSkiTrip(int skiTripId) {
            var skiTrip = await _context.SkiTrips.FindAsync(skiTripId);
            if(skiTrip == null) {
                throw new Exception(
                    "Invalid; trip does not exist"
                    );
            }
            //Automatically checks the number of Skiiers attached to the tripID and updates the INT value on SkiTrip
            skiTrip.Attendees = (from STA in _context.SkiTripAttendees
                                 join ST in _context.SkiTrips
                                 on STA.SkiTripId equals ST.Id
                                 where skiTripId == STA.SkiTripId
                                 select new {
                                     Skiiers = ST.Skiiers
                                 }).Count();

            //calculate housing cost as a function of # of nights and 1 night cost. Days = total days -1.
            skiTrip.HousingTotal = (from ST in _context.SkiTrips
                                    where skiTripId == ST.Id
                                    select new {
                                        HousingTot = ST.HousingCost * (ST.Departure.DayNumber - (ST.Arrival.DayNumber + 1))
                                    }).Sum(x => x.HousingTot);



        }


        // GET: api/SkiTrips
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkiTrip>>> GetSkiTrips()
        {
            return await _context.SkiTrips.ToListAsync();
        }

        // GET: api/SkiTrips/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkiTrip>> GetSkiTrip(int id) {
            var skiTrip = await _context.SkiTrips
                                                .Include(x => x.SkiTripLines)!
                                                .ThenInclude(x => x.Run)
                                                .Include(x => x.Skiiers)
                                                .SingleOrDefaultAsync(x => x.Id == id);


            if (skiTrip == null) {
                return NotFound();
            }

            return skiTrip;
        }

        // PUT: api/SkiTrips/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkiTrip(int id, SkiTrip skiTrip)
        {
            if (id != skiTrip.Id)
            {
                return BadRequest();
            }

            _context.Entry(skiTrip).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkiTripExists(id))
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

        // POST: api/SkiTrips
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkiTrip>> PostSkiTrip(SkiTrip skiTrip)
        {
            _context.SkiTrips.Add(skiTrip);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSkiTrip", new { id = skiTrip.Id }, skiTrip);
        }

        // DELETE: api/SkiTrips/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkiTrip(int id)
        {
            var skiTrip = await _context.SkiTrips.FindAsync(id);
            if (skiTrip == null)
            {
                return NotFound();
            }

            _context.SkiTrips.Remove(skiTrip);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkiTripExists(int id)
        {
            return _context.SkiTrips.Any(e => e.Id == id);
        }
    }
}
