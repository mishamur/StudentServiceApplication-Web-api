using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentServiceApplication;
using StudentServiceApplication.Models;

namespace StudentServiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteresController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public InteresController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Interes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interes>>> GetInterests()
        {
          if (_context.Interests == null)
          {
              return NotFound();
          }
            return await _context.Interests.ToListAsync();
        }

        // GET: api/Interes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Interes>> GetInteres(Guid id)
        {
          if (_context.Interests == null)
          {
              return NotFound();
          }
            var interes = await _context.Interests.FindAsync(id);

            if (interes == null)
            {
                return NotFound();
            }

            return interes;
        }

        // PUT: api/Interes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInteres(Guid id, Interes interes)
        {
            if (id != interes.InteresId)
            {
                return BadRequest();
            }

            _context.Entry(interes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InteresExists(id))
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

        // POST: api/Interes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Interes>> PostInteres(Interes interes)
        {
          if (_context.Interests == null)
          {
              return Problem("Entity set 'ApplicationContext.Interests'  is null.");
          }
            _context.Interests.Add(interes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInteres", new { id = interes.InteresId }, interes);
        }

        // DELETE: api/Interes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInteres(Guid id)
        {
            if (_context.Interests == null)
            {
                return NotFound();
            }
            var interes = await _context.Interests.FindAsync(id);
            if (interes == null)
            {
                return NotFound();
            }

            _context.Interests.Remove(interes);
            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        [NonAction]
        private bool InteresExists(Guid id)
        {
            return (_context.Interests?.Any(e => e.InteresId == id)).GetValueOrDefault();
        }
    }
}
