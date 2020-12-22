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
    public class WeightTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public WeightTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/WeightTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeightTestResult>>> GetWeightTestResults()
        {
            return await _context.WeightTestResults.ToListAsync();
        }

        // GET: api/WeightTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WeightTestResult>> GetWeightTestResult(int id)
        {
            var weightTestResult = await _context.WeightTestResults.FindAsync(id);

            if (weightTestResult == null)
            {
                return NotFound();
            }

            return weightTestResult;
        }

        // PUT: api/WeightTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeightTestResult(int id, WeightTestResult weightTestResult)
        {
            if (id != weightTestResult.WeightTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(weightTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeightTestResultExists(id))
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

        // POST: api/WeightTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WeightTestResult>> PostWeightTestResult(WeightTestResult weightTestResult)
        {
            _context.WeightTestResults.Add(weightTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWeightTestResult", new { id = weightTestResult.WeightTestResultId }, weightTestResult);
        }

        // DELETE: api/WeightTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WeightTestResult>> DeleteWeightTestResult(int id)
        {
            var weightTestResult = await _context.WeightTestResults.FindAsync(id);
            if (weightTestResult == null)
            {
                return NotFound();
            }

            _context.WeightTestResults.Remove(weightTestResult);
            await _context.SaveChangesAsync();

            return weightTestResult;
        }

        private bool WeightTestResultExists(int id)
        {
            return _context.WeightTestResults.Any(e => e.WeightTestResultId == id);
        }
    }
}
