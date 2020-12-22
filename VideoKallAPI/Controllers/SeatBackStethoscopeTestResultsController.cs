using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoKallAPI.Models;

namespace VideoKallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatBackStethoscopeTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public SeatBackStethoscopeTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/SeatBackStethoscopeTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SeatBackStethoscopeTestResult>>> GetSeatBackStethoscopeTestResults()
        {
            return await _context.SeatBackStethoscopeTestResults.ToListAsync();
        }

        // GET: api/SeatBackStethoscopeTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SeatBackStethoscopeTestResult>> GetSeatBackStethoscopeTestResult(int id)
        {
            var seatBackStethoscopeTestResult = await _context.SeatBackStethoscopeTestResults.FindAsync(id);

            if (seatBackStethoscopeTestResult == null)
            {
                return NotFound();
            }

            return seatBackStethoscopeTestResult;
        }

        // PUT: api/SeatBackStethoscopeTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeatBackStethoscopeTestResult(int id, SeatBackStethoscopeTestResult seatBackStethoscopeTestResult)
        {
            if (id != seatBackStethoscopeTestResult.SeatBackStethoscopeTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(seatBackStethoscopeTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeatBackStethoscopeTestResultExists(id))
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

        // POST: api/SeatBackStethoscopeTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SeatBackStethoscopeTestResult>> PostSeatBackStethoscopeTestResult(SeatBackStethoscopeTestResult seatBackStethoscopeTestResult)
        {
            _context.SeatBackStethoscopeTestResults.Add(seatBackStethoscopeTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeatBackStethoscopeTestResult", new { id = seatBackStethoscopeTestResult.SeatBackStethoscopeTestResultId }, seatBackStethoscopeTestResult);
        }

        // DELETE: api/SeatBackStethoscopeTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SeatBackStethoscopeTestResult>> DeleteSeatBackStethoscopeTestResult(int id)
        {
            var seatBackStethoscopeTestResult = await _context.SeatBackStethoscopeTestResults.FindAsync(id);
            if (seatBackStethoscopeTestResult == null)
            {
                return NotFound();
            }

            _context.SeatBackStethoscopeTestResults.Remove(seatBackStethoscopeTestResult);
            await _context.SaveChangesAsync();

            return seatBackStethoscopeTestResult;
        }

        private bool SeatBackStethoscopeTestResultExists(int id)
        {
            return _context.SeatBackStethoscopeTestResults.Any(e => e.SeatBackStethoscopeTestResultId == id);
        }
    }
}
