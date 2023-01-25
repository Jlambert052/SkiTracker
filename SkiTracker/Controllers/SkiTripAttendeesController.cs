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
    public class SkiTripAttendeesController : ControllerBase
    {
        private readonly SkiTrackerDbContext _context;

        public SkiTripAttendeesController(SkiTrackerDbContext context)
        {
            _context = context;
        }

        // GET: api/SkiTripAttendees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkiTripAttendee>>> GetSkiTripAttendees()
        {
            return await _context.SkiTripAttendees.ToListAsync();
        }



        //PRIVATE: Update functionality

        //Update # of attendees in SkiTrip based on changes to SkiTripAttendees
        /* obselete; added on Ski Trip Controller.
         * private async Task<ActionResult> UpdateAttendeeInt(int SkiTripAttendeeId) {
            var SkiTripAttendee = await _context.SkiTripAttendees.FindAsync(SkiTripAttendeeId);

            if(SkiTripAttendee == null) {
                throw new Exception(
                    "Error; entry does not exist");
            }
            var SkiTrip = await _context.SkiTrips.FindAsync(SkiTripAttendee.SkiTripId);

            SkiTrip.Attendees = (from ST in _context.SkiTrips
                                 join STA in _context.SkiTripAttendees
                                 on ST.Id equals STA.SkiTripId
                                 select new {
                                     AttendeeTotal = ST.Skiiers
                                 }).Count();
        }
        */

        //Update LodgePaid to check if the amount under PaidAmount is = to LodgingCost
        //private async Task<ActionResult> UpdateLodgePaid(int SkiTripAttendeeId) {}
        

        // GET: api/SkiTripAttendees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkiTripAttendee>> GetSkiTripAttendee(int id)
        {
            var skiTripAttendee = await _context.SkiTripAttendees.FindAsync(id);

            if (skiTripAttendee == null)
            {
                return NotFound();
            }

            return skiTripAttendee;
        }

        // PUT: api/SkiTripAttendees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkiTripAttendee(int id, SkiTripAttendee skiTripAttendee)
        {
            if (id != skiTripAttendee.Id)
            {
                return BadRequest();
            }

            _context.Entry(skiTripAttendee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkiTripAttendeeExists(id))
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

        // POST: api/SkiTripAttendees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkiTripAttendee>> PostSkiTripAttendee(SkiTripAttendee skiTripAttendee)
        {
            _context.SkiTripAttendees.Add(skiTripAttendee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSkiTripAttendee", new { id = skiTripAttendee.Id }, skiTripAttendee);
        }

        // DELETE: api/SkiTripAttendees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkiTripAttendee(int id)
        {
            var skiTripAttendee = await _context.SkiTripAttendees.FindAsync(id);
            if (skiTripAttendee == null)
            {
                return NotFound();
            }

            _context.SkiTripAttendees.Remove(skiTripAttendee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkiTripAttendeeExists(int id)
        {
            return _context.SkiTripAttendees.Any(e => e.Id == id);
        }
    }
}
