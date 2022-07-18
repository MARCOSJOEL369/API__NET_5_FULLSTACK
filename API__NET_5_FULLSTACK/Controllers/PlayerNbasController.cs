using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API__NET_5_FULLSTACK.context;
using API__NET_5_FULLSTACK.models;

namespace API__NET_5_FULLSTACK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerNbasController : ControllerBase
    {
        private readonly DbContextApp _context;

        public PlayerNbasController(DbContextApp context)
        {
            _context = context;
        }

        // GET: api/PlayerNbas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerNba>>> GetPlayerNba()
        {
            return await _context.PlayerNba.ToListAsync();
        }

        // GET: api/PlayerNbas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerNba>> GetPlayerNba(int id)
        {
            var playerNba = await _context.PlayerNba.FindAsync(id);

            if (playerNba == null)
            {
                return NotFound();
            }

            return playerNba;
        }

        // PUT: api/PlayerNbas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayerNba(int id, PlayerNba playerNba)
        {
            if (id != playerNba.Id)
            {
                return BadRequest();
            }

            _context.Entry(playerNba).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerNbaExists(id))
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

        // POST: api/PlayerNbas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayerNba>> PostPlayerNba(PlayerNba playerNba)
        {
            _context.PlayerNba.Add(playerNba);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayerNba", new { id = playerNba.Id }, playerNba);
        }

        // DELETE: api/PlayerNbas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerNba(int id)
        {
            var playerNba = await _context.PlayerNba.FindAsync(id);
            if (playerNba == null)
            {
                return NotFound();
            }

            _context.PlayerNba.Remove(playerNba);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerNbaExists(int id)
        {
            return _context.PlayerNba.Any(e => e.Id == id);
        }
    }
}
