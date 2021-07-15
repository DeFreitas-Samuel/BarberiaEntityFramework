﻿using System;
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
    public class TipoEmpleadoesController : ControllerBase
    {
        private readonly BarberiaEntityFrameworkContext _context;

        public TipoEmpleadoesController(BarberiaEntityFrameworkContext context)
        {
            _context = context;
        }

        // GET: api/TipoEmpleadoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEmpleado>>> GetTipoEmpleado()
        {
            return await _context.TipoEmpleado.ToListAsync();
        }

        // GET: api/TipoEmpleadoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoEmpleado>> GetTipoEmpleado(int id)
        {
            var tipoEmpleado = await _context.TipoEmpleado.FindAsync(id);

            if (tipoEmpleado == null)
            {
                return NotFound();
            }

            return tipoEmpleado;
        }

        // PUT: api/TipoEmpleadoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoEmpleado(int id, TipoEmpleado tipoEmpleado)
        {
            if (id != tipoEmpleado.ID)
            {
                return BadRequest();
            }

            _context.Entry(tipoEmpleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoEmpleadoExists(id))
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

        // POST: api/TipoEmpleadoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoEmpleado>> PostTipoEmpleado(TipoEmpleado tipoEmpleado)
        {
            _context.TipoEmpleado.Add(tipoEmpleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoEmpleado", new { id = tipoEmpleado.ID }, tipoEmpleado);
        }

        // DELETE: api/TipoEmpleadoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoEmpleado(int id)
        {
            var tipoEmpleado = await _context.TipoEmpleado.FindAsync(id);
            if (tipoEmpleado == null)
            {
                return NotFound();
            }

            _context.TipoEmpleado.Remove(tipoEmpleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoEmpleadoExists(int id)
        {
            return _context.TipoEmpleado.Any(e => e.ID == id);
        }
    }
}
