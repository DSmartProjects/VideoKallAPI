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
    public class ChestStethoscopeTestResultsController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public ChestStethoscopeTestResultsController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/ChestStethoscopeTestResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChestStethoscopeTestResult>>> GetChestStethoscopeTestResults()
        {
            return await _context.ChestStethoscopeTestResults.ToListAsync();
        }

        // GET: api/ChestStethoscopeTestResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChestStethoscopeTestResult>> GetChestStethoscopeTestResult(int id)
        {
            var chestStethoscopeTestResult = await _context.ChestStethoscopeTestResults.FindAsync(id);

            if (chestStethoscopeTestResult == null)
            {
                return NotFound();
            }

            return chestStethoscopeTestResult;
        }

        // PUT: api/ChestStethoscopeTestResults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChestStethoscopeTestResult(int id, ChestStethoscopeTestResult chestStethoscopeTestResult)
        {
            if (id != chestStethoscopeTestResult.ChestStethoscopeTestResultId)
            {
                return BadRequest();
            }

            _context.Entry(chestStethoscopeTestResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChestStethoscopeTestResultExists(id))
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

        // POST: api/ChestStethoscopeTestResults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChestStethoscopeTestResult>> PostChestStethoscopeTestResult(ChestStethoscopeTestResult chestStethoscopeTestResult)
        {
            _context.ChestStethoscopeTestResults.Add(chestStethoscopeTestResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChestStethoscopeTestResult", new { id = chestStethoscopeTestResult.ChestStethoscopeTestResultId }, chestStethoscopeTestResult);
        }

        // DELETE: api/ChestStethoscopeTestResults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChestStethoscopeTestResult>> DeleteChestStethoscopeTestResult(int id)
        {
            var chestStethoscopeTestResult = await _context.ChestStethoscopeTestResults.FindAsync(id);
            if (chestStethoscopeTestResult == null)
            {
                return NotFound();
            }

            _context.ChestStethoscopeTestResults.Remove(chestStethoscopeTestResult);
            await _context.SaveChangesAsync();

            return chestStethoscopeTestResult;
        }

        private bool ChestStethoscopeTestResultExists(int id)
        {
            return _context.ChestStethoscopeTestResults.Any(e => e.ChestStethoscopeTestResultId == id);
        }
    }
}
