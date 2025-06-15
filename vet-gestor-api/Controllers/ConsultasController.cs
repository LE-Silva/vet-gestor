using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vet_gestor_api.Data;
using vet_gestor_api.Models;

namespace vet_gestor_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultasController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ConsultasController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Consultas
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Consulta>>> GetConsultas()
    {
        return await _context.Consultas.ToListAsync();
    }

    // GET: api/Consultas/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Consulta>> GetConsulta(int id)
    {
        var consulta = await _context.Consultas.FindAsync(id);

        if (consulta == null)
        {
            return NotFound();
        }

        return consulta;
    }

    // POST: api/Consultas
    [HttpPost]
    public async Task<ActionResult<Consulta>> PostConsulta(Consulta consulta)
    {
        _context.Consultas.Add(consulta);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetConsulta), new { id = consulta.Id }, consulta);
    }

    // PUT: api/Consultas/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutConsulta(int id, Consulta consulta)
    {
        if (id != consulta.Id)
        {
            return BadRequest();
        }

        _context.Entry(consulta).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ConsultaExists(id))
            {
                return NotFound();
            }
            throw;
        }

        return NoContent();
    }

    // DELETE: api/Consultas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteConsulta(int id)
    {
        var consulta = await _context.Consultas.FindAsync(id);
        if (consulta == null)
        {
            return NotFound();
        }

        _context.Consultas.Remove(consulta);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ConsultaExists(int id)
    {
        return _context.Consultas.Any(e => e.Id == id);
    }
}
