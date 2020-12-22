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
    public class HeightTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public HeightTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/HeightTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeightTestResult>>> GetHeightTestResults()
        {
            return await _context.HeightTestResults.ToListAsync();
        }

        // GET: api/HeightTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HeightTestResult>> GetHeightTestResult(int id)
        {
            var heightTestResult = await _context.HeightTestResults.FindAsync(id);

            if (heightTestResult == null)
            {
                return NotFound();
            }

            return heightTestResult;
        }

        // PUT: api/HeightTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHeightTestResult(int id, HeightTestResult heightTestResult)
        {
            if (id != heightTestResult.HeightTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(heightTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeightTestResultExists(id))
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

        // POST: api/HeightTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HeightTestResult>> PostHeightTestResult(HeightTestResult heightTestResult)
        {
            _context.HeightTestResults.Add(heightTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHeightTestResult", new { id = heightTestResult.HeightTestResultId }, heightTestResult);
        }

        // DELETE: api/HeightTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HeightTestResult>> DeleteHeightTestResult(int id)
        {
            var heightTestResult = await _context.HeightTestResults.FindAsync(id);
            if (heightTestResult == null)
            {
                return NotFound();
            }

            _context.HeightTestResults.Remove(heightTestResult);
            await _context.SaveChangesAsync();

            return heightTestResult;
        }

        private bool HeightTestResultExists(int id)
        {
            return _context.HeightTestResults.Any(e => e.HeightTestResultId == id);
        }
    }
}
