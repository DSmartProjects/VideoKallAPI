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
    public class DermatoscopeTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public DermatoscopeTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/DermatoscopeTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DermatoscopeTestResult>>> GetDermatoscopeTestResults()
        {
            return await _context.DermatoscopeTestResults.ToListAsync();
        }

        // GET: api/DermatoscopeTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DermatoscopeTestResult>> GetDermatoscopeTestResult(int id)
        {
            var dermatoscopeTestResult = await _context.DermatoscopeTestResults.FindAsync(id);

            if (dermatoscopeTestResult == null)
            {
                return NotFound();
            }

            return dermatoscopeTestResult;
        }

        // PUT: api/DermatoscopeTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDermatoscopeTestResult(int id, DermatoscopeTestResult dermatoscopeTestResult)
        {
            if (id != dermatoscopeTestResult.DermatoscopeTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(dermatoscopeTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DermatoscopeTestResultExists(id))
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

        // POST: api/DermatoscopeTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DermatoscopeTestResult>> PostDermatoscopeTestResult(DermatoscopeTestResult dermatoscopeTestResult)
        {
            _context.DermatoscopeTestResults.Add(dermatoscopeTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDermatoscopeTestResult", new { id = dermatoscopeTestResult.DermatoscopeTestResultId }, dermatoscopeTestResult);
        }

        // DELETE: api/DermatoscopeTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DermatoscopeTestResult>> DeleteDermatoscopeTestResult(int id)
        {
            var dermatoscopeTestResult = await _context.DermatoscopeTestResults.FindAsync(id);
            if (dermatoscopeTestResult == null)
            {
                return NotFound();
            }

            _context.DermatoscopeTestResults.Remove(dermatoscopeTestResult);
            await _context.SaveChangesAsync();

            return dermatoscopeTestResult;
        }

        private bool DermatoscopeTestResultExists(int id)
        {
            return _context.DermatoscopeTestResults.Any(e => e.DermatoscopeTestResultId == id);
        }
    }
}
