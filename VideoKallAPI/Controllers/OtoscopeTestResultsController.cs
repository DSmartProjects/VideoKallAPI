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
    public class OtoscopeTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public OtoscopeTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/OtoscopeTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OtoscopeTestResult>>> GetOtoscopeTestResults()
        {
            return await _context.OtoscopeTestResults.ToListAsync();
        }

        // GET: api/OtoscopeTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OtoscopeTestResult>> GetOtoscopeTestResult(int id)
        {
            var otoscopeTestResult = await _context.OtoscopeTestResults.FindAsync(id);

            if (otoscopeTestResult == null)
            {
                return NotFound();
            }

            return otoscopeTestResult;
        }

        // PUT: api/OtoscopeTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOtoscopeTestResult(int id, OtoscopeTestResult otoscopeTestResult)
        {
            if (id != otoscopeTestResult.OtoscopeTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(otoscopeTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OtoscopeTestResultExists(id))
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

        // POST: api/OtoscopeTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<OtoscopeTestResult>> PostOtoscopeTestResult(OtoscopeTestResult otoscopeTestResult)
        {
            _context.OtoscopeTestResults.Add(otoscopeTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOtoscopeTestResult", new { id = otoscopeTestResult.OtoscopeTestResultId }, otoscopeTestResult);
        }

        // DELETE: api/OtoscopeTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OtoscopeTestResult>> DeleteOtoscopeTestResult(int id)
        {
            var otoscopeTestResult = await _context.OtoscopeTestResults.FindAsync(id);
            if (otoscopeTestResult == null)
            {
                return NotFound();
            }

            _context.OtoscopeTestResults.Remove(otoscopeTestResult);
            await _context.SaveChangesAsync();

            return otoscopeTestResult;
        }

        private bool OtoscopeTestResultExists(int id)
        {
            return _context.OtoscopeTestResults.Any(e => e.OtoscopeTestResultId == id);
        }
    }
}
