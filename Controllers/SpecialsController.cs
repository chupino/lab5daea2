using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingPizza.PizzaData;

namespace BlazingPizza.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
    // GET: /specials/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<PizzaSpecial>> GetSpecial(int id)
    {
        var special = await _db.Specials.FindAsync(id);
        if (special == null)
        {
            return NotFound();
        }
        return special;
    }

    // POST: /specials
    [HttpPost]
    public async Task<ActionResult<PizzaSpecial>> CreateSpecial(PizzaSpecial special)
    {
        _db.Specials.Add(special);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetSpecial), new { id = special.Id }, special);
    }

    // PUT: /specials/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSpecial(int id, PizzaSpecial special)
    {
        if (id != special.Id)
        {
            return BadRequest();
        }

        _db.Entry(special).State = EntityState.Modified;

        try
        {
            await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SpecialExists(id))
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

    // DELETE: /specials/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSpecial(int id)
    {
        var special = await _db.Specials.FindAsync(id);
        if (special == null)
        {
            return NotFound();
        }

        _db.Specials.Remove(special);
        await _db.SaveChangesAsync();

        return NoContent();
    }

    private bool SpecialExists(int id)
    {
        return _db.Specials.Any(e => e.Id == id);
    }
}
