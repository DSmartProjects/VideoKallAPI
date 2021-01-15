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
    public class ClinicalNotesController : ControllerBase
    {
        private readonly VK_SMCContext _context;

        public ClinicalNotesController(VK_SMCContext context)
        {
            _context = context;
        }

        // GET: api/ClinicalNotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClinicalNote>>> GetClinicalNotes()
        {
            return await _context.ClinicalNotes.ToListAsync();
        }

        // GET: api/ClinicalNotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClinicalNote>> GetClinicalNote(int id)
        {
            var clinicalNote = await _context.ClinicalNotes.FindAsync(id);

            if (clinicalNote == null)
            {
                return NotFound();
            }

            return clinicalNote;
        }

        // PUT: api/ClinicalNotes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClinicalNote(int id, ClinicalNote clinicalNote)
        {
            if (id != clinicalNote.ClinicalNoteId)
            {
                return BadRequest();
            }

            _context.Entry(clinicalNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClinicalNoteExists(id))
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

        // POST: api/ClinicalNotes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ClinicalNote>> PostClinicalNote(ClinicalNote clinicalNote)
        {
            _context.ClinicalNotes.Add(clinicalNote);
            try
            {
                _context.Database.EnsureCreated();
                await _context.SaveChangesAsync();
            }
            catch( Exception ex)
            {
                throw ex;
            }
            

            return CreatedAtAction("GetClinicalNote", new { id = clinicalNote.ClinicalNoteId }, clinicalNote);
        }

        // DELETE: api/ClinicalNotes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ClinicalNote>> DeleteClinicalNote(int id)
        {
            var clinicalNote = await _context.ClinicalNotes.FindAsync(id);
            if (clinicalNote == null)
            {
                return NotFound();
            }

            _context.ClinicalNotes.Remove(clinicalNote);
            await _context.SaveChangesAsync();

            return clinicalNote;
        }

        private bool ClinicalNoteExists(int id)
        {
            return _context.ClinicalNotes.Any(e => e.ClinicalNoteId == id);
        }
    }
}
