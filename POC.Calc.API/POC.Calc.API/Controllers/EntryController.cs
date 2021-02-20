using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC.Calc.API;

namespace POC.Calc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        private readonly APIContext _context;

        public EntryController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Entry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatabaseModel>>> GetDatabaseModel()
        {
            return await _context.DatabaseModel.ToListAsync();
        }

        // GET: api/Entry/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DatabaseModel>> GetDatabaseModel(int id)
        {
            var databaseModel = await _context.DatabaseModel.FindAsync(id);

            if (databaseModel == null)
            {
                return NotFound();
            }

            return databaseModel;
        }

        // PUT: api/Entry/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDatabaseModel(int id, DatabaseModel databaseModel)
        {
            if (id != databaseModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(databaseModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DatabaseModelExists(id))
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

        // POST: api/Entry
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DatabaseModel>> PostDatabaseModel(DatabaseModel databaseModel)
        {
            _context.DatabaseModel.Add(databaseModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDatabaseModel", new { id = databaseModel.ID }, databaseModel);
        }

        // DELETE: api/Entry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDatabaseModel(int id)
        {
            var databaseModel = await _context.DatabaseModel.FindAsync(id);
            if (databaseModel == null)
            {
                return NotFound();
            }

            _context.DatabaseModel.Remove(databaseModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DatabaseModelExists(int id)
        {
            return _context.DatabaseModel.Any(e => e.ID == id);
        }
    }
}
