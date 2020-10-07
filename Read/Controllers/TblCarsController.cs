using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityLayer.Models;

namespace ReadService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblCarsController : ControllerBase
    {
        private readonly DbMicroservicesDemoContext _context;

        public TblCarsController(DbMicroservicesDemoContext context)
        {
            _context = context;
        }

        // GET: api/TblCars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblCar>>> GetTblCar()
        {
            return await _context.TblCar.ToListAsync();
        }

        // GET: api/TblCars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCar>> GetTblCar(int id)
        {
            var tblCar = await _context.TblCar.FindAsync(id);

            if (tblCar == null)
            {
                return NotFound();
            }

            return tblCar;
        }

        // PUT: api/TblCars/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCar(int id, TblCar tblCar)
        {
            if (id != tblCar.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCarExists(id))
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

        // POST: api/TblCars
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCar>> PostTblCar(TblCar tblCar)
        {
            _context.TblCar.Add(tblCar);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblCarExists(tblCar.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblCar", new { id = tblCar.Id }, tblCar);
        }

        // DELETE: api/TblCars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCar>> DeleteTblCar(int id)
        {
            var tblCar = await _context.TblCar.FindAsync(id);
            if (tblCar == null)
            {
                return NotFound();
            }

            _context.TblCar.Remove(tblCar);
            await _context.SaveChangesAsync();

            return tblCar;
        }

        private bool TblCarExists(int id)
        {
            return _context.TblCar.Any(e => e.Id == id);
        }
    }
}
