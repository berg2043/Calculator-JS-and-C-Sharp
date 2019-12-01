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

        [HttpGet]
        public ActionResult<List<MathHistory>> GetAll() =>
            _context.MathHistories.ToList();

        // GET by ID action

        // POST action

        // PUT action

        // DELETE action
    }
}