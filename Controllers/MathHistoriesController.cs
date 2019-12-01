using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Api.Data;
using Test.Api.Models;

namespace Test.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MathHistoriesController : ControllerBase
  {
    private readonly TestContext _context;

    public MathHistoriesController(TestContext context)
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
    // [HttpPost]
    // public async Task<ActionResult<MathHistory>> Create(MathHistory MathHistory)
    // {
    //   _context.MathHistories.Add(MathHistory);
    //   await _context.SaveChangesAsync();

    //   return CreatedAtAction(nameof(GetById), new { id = MathHistory.Id }, MathHistory);
    // }
    // PUT action

    // DELETE action
  }
}