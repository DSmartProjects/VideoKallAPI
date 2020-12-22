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
    public class PulseOximeterTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public PulseOximeterTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/PulseOximeterTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PulseOximeterTestResult>>> GetPulseOximeterTestResults()
        {
            return await _context.PulseOximeterTestResults.ToListAsync();
        }

        // GET: api/PulseOximeterTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PulseOximeterTestResult>> GetPulseOximeterTestResult(int id)
        {
            var pulseOximeterTestResult = await _context.PulseOximeterTestResults.FindAsync(id);

            if (pulseOximeterTestResult == null)
            {
                return NotFound();
            }

            return pulseOximeterTestResult;
        }

        // PUT: api/PulseOximeterTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPulseOximeterTestResult(int id, PulseOximeterTestResult pulseOximeterTestResult)
        {
            if (id != pulseOximeterTestResult.PulseOximeterTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(pulseOximeterTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PulseOximeterTestResultExists(id))
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

        // POST: api/PulseOximeterTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PulseOximeterTestResult>> PostPulseOximeterTestResult(PulseOximeterTestResult pulseOximeterTestResult)
        {
            _context.PulseOximeterTestResults.Add(pulseOximeterTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPulseOximeterTestResult", new { id = pulseOximeterTestResult.PulseOximeterTestResultId }, pulseOximeterTestResult);
        }

        // DELETE: api/PulseOximeterTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PulseOximeterTestResult>> DeletePulseOximeterTestResult(int id)
        {
            var pulseOximeterTestResult = await _context.PulseOximeterTestResults.FindAsync(id);
            if (pulseOximeterTestResult == null)
            {
                return NotFound();
            }

            _context.PulseOximeterTestResults.Remove(pulseOximeterTestResult);
            await _context.SaveChangesAsync();

            return pulseOximeterTestResult;
        }

        private bool PulseOximeterTestResultExists(int id)
        {
            return _context.PulseOximeterTestResults.Any(e => e.PulseOximeterTestResultId == id);
        }
    }
}
