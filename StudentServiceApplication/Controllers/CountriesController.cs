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
    public class CountriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CountriesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
          if (_context.Countries == null)
          {
              return NotFound();
          }
            return await _context.Countries.ToListAsync();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(Guid id)
        {
          if (_context.Countries == null)
          {
              return NotFound();
          }
            var country = await _context.Countries.FindAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        private bool CountryExists(Guid id)
        {
            return (_context.Countries?.Any(e => e.CountryId == id)).GetValueOrDefault();
        }
    }
}
