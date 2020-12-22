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
    public class SpirometerTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public SpirometerTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/SpirometerTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpirometerTestResult>>> GetSpirometerTestResults()
        {
            return await _context.SpirometerTestResults.ToListAsync();
        }

        // GET: api/SpirometerTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpirometerTestResult>> GetSpirometerTestResult(int id)
        {
            var spirometerTestResult = await _context.SpirometerTestResults.FindAsync(id);

            if (spirometerTestResult == null)
            {
                return NotFound();
            }

            return spirometerTestResult;
        }

        // PUT: api/SpirometerTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpirometerTestResult(int id, SpirometerTestResult spirometerTestResult)
        {
            if (id != spirometerTestResult.SpirometerTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(spirometerTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpirometerTestResultExists(id))
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

        // POST: api/SpirometerTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SpirometerTestResult>> PostSpirometerTestResult(SpirometerTestResult spirometerTestResult)
        {
            _context.SpirometerTestResults.Add(spirometerTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpirometerTestResult", new { id = spirometerTestResult.SpirometerTestResultId }, spirometerTestResult);
        }

        // DELETE: api/SpirometerTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SpirometerTestResult>> DeleteSpirometerTestResult(int id)
        {
            var spirometerTestResult = await _context.SpirometerTestResults.FindAsync(id);
            if (spirometerTestResult == null)
            {
                return NotFound();
            }

            _context.SpirometerTestResults.Remove(spirometerTestResult);
            await _context.SaveChangesAsync();

            return spirometerTestResult;
        }

        private bool SpirometerTestResultExists(int id)
        {
            return _context.SpirometerTestResults.Any(e => e.SpirometerTestResultId == id);
        }
    }
}
