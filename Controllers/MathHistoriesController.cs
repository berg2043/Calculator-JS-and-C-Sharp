using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Calculator.Api.Data;
using Calculator.Api.Models;

namespace Calculator.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MathHistoriesController : ControllerBase
  {
    private readonly CalculatorContext _context;

    public MathHistoriesController(CalculatorContext context)
    {
      _context = context;
    }

    // Get Request returns all
    [HttpGet]
    public ActionResult<List<MathHistory>> GetAll() =>
        _context.MathHistories.ToList();

    // GET by ID action. Required for POST and DELTE
    [HttpGet("{id}")]
    public async Task<ActionResult<MathHistory>> GetById(long id)
    {
      var product = await _context.MathHistories.FindAsync(id);

      if (product == null)
      {
        return NotFound();
      }

      return product;
    }
    // POST action
    [HttpPost]
    public async Task<ActionResult<MathHistory>> Create(MathHistory mathHistory)
    {
      // Runs equation through SolveMath to return an answer
      mathHistory.Answer = MathSolver.SolveMath(mathHistory.Equation);
      _context.MathHistories.Add(mathHistory);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(GetById), new { id = mathHistory.Id }, mathHistory);
    }
    // DELETE action
    [HttpDelete]
    public async Task<ActionResult> Delete()
    {
      _context.MathHistories.RemoveRange(_context.MathHistories);
      await _context.SaveChangesAsync();
      return NoContent();
    }
  }
}