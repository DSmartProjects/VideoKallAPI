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
    public class ThermometerTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public ThermometerTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/ThermometerTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThermometerTestResult>>> GetThermometerTestResults()
        {
            return await _context.ThermometerTestResults.ToListAsync();
        }

        // GET: api/ThermometerTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThermometerTestResult>> GetThermometerTestResult(int id)
        {
            var thermometerTestResult = await _context.ThermometerTestResults.FindAsync(id);

            if (thermometerTestResult == null)
            {
                return NotFound();
            }

            return thermometerTestResult;
        }

        // PUT: api/ThermometerTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThermometerTestResult(int id, ThermometerTestResult thermometerTestResult)
        {
            if (id != thermometerTestResult.ThermometerTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(thermometerTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThermometerTestResultExists(id))
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

        // POST: api/ThermometerTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ThermometerTestResult>> PostThermometerTestResult(ThermometerTestResult thermometerTestResult)
        {
            _context.ThermometerTestResults.Add(thermometerTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThermometerTestResult", new { id = thermometerTestResult.ThermometerTestResultId }, thermometerTestResult);
        }

        // DELETE: api/ThermometerTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ThermometerTestResult>> DeleteThermometerTestResult(int id)
        {
            var thermometerTestResult = await _context.ThermometerTestResults.FindAsync(id);
            if (thermometerTestResult == null)
            {
                return NotFound();
            }

            _context.ThermometerTestResults.Remove(thermometerTestResult);
            await _context.SaveChangesAsync();

            return thermometerTestResult;
        }

        private bool ThermometerTestResultExists(int id)
        {
            return _context.ThermometerTestResults.Any(e => e.ThermometerTestResultId == id);
        }
    }
}
