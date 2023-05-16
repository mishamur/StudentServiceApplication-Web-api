using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentServiceApplication;
using StudentServiceApplication.Models;

namespace StudentServiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public InstitutesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Institutes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Institute>>> GetInstitutes()
        {
          if (_context.Institutes == null)
          {
              return NotFound();
          }
            return await _context.Institutes.ToListAsync();
        }

        // GET: api/Institutes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Institute>> GetInstitute(Guid id)
        {
          if (_context.Institutes == null)
          {
              return NotFound();
          }
            var institute = await _context.Institutes.FindAsync(id);

            if (institute == null)
            {
                return NotFound();
            }

            return institute;
        }

        // PUT: api/Institutes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutInstitute(Guid id, Institute institute)
        {
            if (id != institute.IstituteId)
            {
                return BadRequest();
            }

            _context.Entry(institute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstituteExists(id))
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

        // POST: api/Institutes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Institute>> PostInstitute(Institute institute)
        {
          if (_context.Institutes == null)
          {
              return Problem("Entity set 'ApplicationContext.Institutes'  is null.");
          }
            _context.Institutes.Add(institute);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstitute", new { id = institute.IstituteId }, institute);
        }

        // DELETE: api/Institutes/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteInstitute(Guid id)
        {
            if (_context.Institutes == null)
            {
                return NotFound();
            }
            var institute = await _context.Institutes.FindAsync(id);
            if (institute == null)
            {
                return NotFound();
            }

            _context.Institutes.Remove(institute);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstituteExists(Guid id)
        {
            return (_context.Institutes?.Any(e => e.IstituteId == id)).GetValueOrDefault();
        }
    }
}
