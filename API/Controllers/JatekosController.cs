using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using ClassLibrary.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JatekosController : ControllerBase
    {
        private readonly APIContext _context;

        public JatekosController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Jatekos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jatekos>>> GetJatekos()
        {
          if (_context.Jatekos == null)
          {
              return NotFound();
          }
            return await _context.Jatekos.Include(x=>x.Tipp).ToListAsync();
        }

        // GET: api/Jatekos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jatekos>> GetJatekos(int id)
        {
          if (_context.Jatekos == null)
          {
              return NotFound();
          }
            var jatekos = await _context.Jatekos.Where(x=>x.Id==id).Include(x=>x.Tipp).FirstOrDefaultAsync();

            if (jatekos == null)
            {
                return NotFound();
            }

            return jatekos;
        }

        // PUT: api/Jatekos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJatekos(int id, Jatekos jatekos)
        {
            if (id != jatekos.Id)
            {
                return BadRequest();
            }

            _context.Entry(jatekos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JatekosExists(id))
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

        // POST: api/Jatekos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Jatekos>> PostJatekos(Jatekos jatekos)
        {
          if (_context.Jatekos == null)
          {
              return Problem("Entity set 'APIContext.Jatekos'  is null.");
          }
            _context.Jatekos.Add(jatekos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJatekos", new { id = jatekos.Id }, jatekos);
        }

        // DELETE: api/Jatekos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJatekos(int id)
        {
            if (_context.Jatekos == null)
            {
                return NotFound();
            }
            var jatekos = await _context.Jatekos.FindAsync(id);
            if (jatekos == null)
            {
                return NotFound();
            }

            _context.Jatekos.Remove(jatekos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JatekosExists(int id)
        {
            return (_context.Jatekos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
