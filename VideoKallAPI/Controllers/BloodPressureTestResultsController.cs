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
    public class BloodPressureTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public BloodPressureTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/BloodPressureTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BloodPressureTestResult>>> GetBloodPressureTestResults()
        {
            return await _context.BloodPressureTestResults.ToListAsync();
        }

        // GET: api/BloodPressureTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BloodPressureTestResult>> GetBloodPressureTestResult(int id)
        {
            var bloodPressureTestResult = await _context.BloodPressureTestResults.FindAsync(id);

            if (bloodPressureTestResult == null)
            {
                return NotFound();
            }

            return bloodPressureTestResult;
        }

        // PUT: api/BloodPressureTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloodPressureTestResult(int id, BloodPressureTestResult bloodPressureTestResult)
        {
            if (id != bloodPressureTestResult.BloodPressureTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(bloodPressureTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodPressureTestResultExists(id))
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

        // POST: api/BloodPressureTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BloodPressureTestResult>> PostBloodPressureTestResult(BloodPressureTestResult bloodPressureTestResult)
        {
            _context.BloodPressureTestResults.Add(bloodPressureTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBloodPressureTestResult", new { id = bloodPressureTestResult.BloodPressureTestResultId }, bloodPressureTestResult);
        }

        // DELETE: api/BloodPressureTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BloodPressureTestResult>> DeleteBloodPressureTestResult(int id)
        {
            var bloodPressureTestResult = await _context.BloodPressureTestResults.FindAsync(id);
            if (bloodPressureTestResult == null)
            {
                return NotFound();
            }

            _context.BloodPressureTestResults.Remove(bloodPressureTestResult);
            await _context.SaveChangesAsync();

            return bloodPressureTestResult;
        }

        private bool BloodPressureTestResultExists(int id)
        {
            return _context.BloodPressureTestResults.Any(e => e.BloodPressureTestResultId == id);
        }
    }
}
