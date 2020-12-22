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
    public class GlucoseMonitorTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public GlucoseMonitorTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/GlucoseMonitorTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GlucoseMonitorTestResult>>> GetGlucoseMonitorTestResults()
        {
            return await _context.GlucoseMonitorTestResults.ToListAsync();
        }

        // GET: api/GlucoseMonitorTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GlucoseMonitorTestResult>> GetGlucoseMonitorTestResult(int id)
        {
            var glucoseMonitorTestResult = await _context.GlucoseMonitorTestResults.FindAsync(id);

            if (glucoseMonitorTestResult == null)
            {
                return NotFound();
            }

            return glucoseMonitorTestResult;
        }

        // PUT: api/GlucoseMonitorTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlucoseMonitorTestResult(int id, GlucoseMonitorTestResult glucoseMonitorTestResult)
        {
            if (id != glucoseMonitorTestResult.GlucoseMonitorTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(glucoseMonitorTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlucoseMonitorTestResultExists(id))
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

        // POST: api/GlucoseMonitorTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GlucoseMonitorTestResult>> PostGlucoseMonitorTestResult(GlucoseMonitorTestResult glucoseMonitorTestResult)
        {
            _context.GlucoseMonitorTestResults.Add(glucoseMonitorTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlucoseMonitorTestResult", new { id = glucoseMonitorTestResult.GlucoseMonitorTestResultId }, glucoseMonitorTestResult);
        }

        // DELETE: api/GlucoseMonitorTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GlucoseMonitorTestResult>> DeleteGlucoseMonitorTestResult(int id)
        {
            var glucoseMonitorTestResult = await _context.GlucoseMonitorTestResults.FindAsync(id);
            if (glucoseMonitorTestResult == null)
            {
                return NotFound();
            }

            _context.GlucoseMonitorTestResults.Remove(glucoseMonitorTestResult);
            await _context.SaveChangesAsync();

            return glucoseMonitorTestResult;
        }

        private bool GlucoseMonitorTestResultExists(int id)
        {
            return _context.GlucoseMonitorTestResults.Any(e => e.GlucoseMonitorTestResultId == id);
        }
    }
}
