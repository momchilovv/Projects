using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Addresses.Data;
using Addresses.Models;
using System.Data;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Web_API_SQLite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly AddressesContext _context;

        public AddressesController(AddressesContext context)
        {
            _context = context;
        }

        // GET: api/Addresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddresses(string? search)
        {
            if (_context.Addresses == null)
            {
                return NotFound();
            }

            if (search != null)
            {
                return await _context.Addresses.Where(
                      w => w.Street.ToLower().Contains(search) || w.City.ToLower().Contains(search) ||
                      w.Country.ToLower().Contains(search) || w.Zipcode.ToLower().Contains(search) ||
                      w.Housenumber.ToString().Contains(search)).ToListAsync();
            }

            return await _context.Addresses.ToListAsync();
        }

        [HttpGet("Sort")]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddresses(string field, string order)
        {
            if (_context.Addresses == null)
            {
                return NotFound();
            }

            if (field != null && order != null)
            {
                switch (field.ToLower())
                {
                    case "id":
                        if (order.ToLower().StartsWith('a'))
                        {
                            return await _context.Addresses.OrderBy(x => x.Id).ToListAsync();
                        }
                        return await _context.Addresses.OrderByDescending(x => x.Id).ToListAsync();
                    case "street":
                        if (order.ToLower().StartsWith('a'))
                        {
                            return await _context.Addresses.OrderBy(x => x.Street).ToListAsync();
                        }
                        return await _context.Addresses.OrderByDescending(x => x.Street).ToListAsync();
                    case "house number":
                        if (order.ToLower().StartsWith('a'))
                        {
                            return await _context.Addresses.OrderBy(x => x.Housenumber).ToListAsync();
                        }
                        return await _context.Addresses.OrderByDescending(x => x.Housenumber).ToListAsync();
                    case "city":
                        if (order.ToLower().StartsWith('a'))
                        {
                            return await _context.Addresses.OrderBy(x => x.City).ToListAsync();
                        }
                        return await _context.Addresses.OrderByDescending(x => x.City).ToListAsync();
                    case "zipcode":
                        if (order.ToLower().StartsWith('a'))
                        {
                            return await _context.Addresses.OrderBy(x => x.Zipcode).ToListAsync();
                        }
                        return await _context.Addresses.OrderByDescending(x => x.Zipcode).ToListAsync();
                    case "country":
                        if (order.ToLower().StartsWith('a'))
                        {
                            return await _context.Addresses.OrderBy(x => x.Country).ToListAsync();
                        }
                        return await _context.Addresses.OrderByDescending(x => x.Country).ToListAsync();
                        default:
                        return NotFound();
                }
            }
            return NotFound();
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(long id)
        {
            if (_context.Addresses == null)
            {
                return NotFound();
            }
            var address = await _context.Addresses.FindAsync(id);

            if (address == null)
            {
                return NotFound();
            }

            return address;
        }

        // PUT: api/Addresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(long id, Address address)
        {
            if (id != address.Id)
            {
                return BadRequest();
            }

            _context.Entry(address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(id))
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

        // POST: api/Addresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            if (_context.Addresses == null)
            {
                return Problem("Entity set 'AddressesContext.Addresses'  is null.");
            }
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddress", new { id = address.Id }, address);
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(long id)
        {
            if (_context.Addresses == null)
            {
                return NotFound();
            }
            var address = await _context.Addresses.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AddressExists(long id)
        {
            return (_context.Addresses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
