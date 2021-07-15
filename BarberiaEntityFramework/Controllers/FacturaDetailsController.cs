using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BarberiaEntityFramework.Data;
using BarberiaEntityFramework.Models;

namespace BarberiaEntityFramework.Controllers
{
    //Samuel De Freitas
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaDetailsController : ControllerBase
    {
        private readonly BarberiaEntityFrameworkContext _context;

        public FacturaDetailsController(BarberiaEntityFrameworkContext context)
        {
            _context = context;
        }

        // GET: api/FacturaDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturaDetail>>> GetFacturaDetail()
        {
            return await _context.FacturaDetail.ToListAsync();
        }

        // GET: api/FacturaDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacturaDetail>> GetFacturaDetail(int id)
        {
            var facturaDetail = await _context.FacturaDetail.FindAsync(id);

            if (facturaDetail == null)
            {
                return NotFound();
            }

            return facturaDetail;
        }

        // PUT: api/FacturaDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacturaDetail(int id, FacturaDetail facturaDetail)
        {
            if (id != facturaDetail.ID)
            {
                return BadRequest();
            }

            _context.Entry(facturaDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturaDetailExists(id))
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

        // POST: api/FacturaDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FacturaDetail>> PostFacturaDetail(FacturaDetail facturaDetail)
        {
            _context.FacturaDetail.Add(facturaDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacturaDetail", new { id = facturaDetail.ID }, facturaDetail);
        }

        // DELETE: api/FacturaDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacturaDetail(int id)
        {
            var facturaDetail = await _context.FacturaDetail.FindAsync(id);
            if (facturaDetail == null)
            {
                return NotFound();
            }

            _context.FacturaDetail.Remove(facturaDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacturaDetailExists(int id)
        {
            return _context.FacturaDetail.Any(e => e.ID == id);
        }
    }
}
