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

        private bool InteresExists(Guid id)
        {
            return (_context.Interests?.Any(e => e.InteresId == id)).GetValueOrDefault();
        }
    }
}
