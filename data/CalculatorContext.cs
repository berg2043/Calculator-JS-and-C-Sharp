using Microsoft.EntityFrameworkCore;
using Calculator.Api.Models;

// Name to call later
namespace Calculator.Api.Data
{
  // Class to interact with database
  public class CalculatorContext : DbContext
  {
    public CalculatorContext(DbContextOptions<CalculatorContext> options)
        : base(options)
    {
    }

    public DbSet<MathHistory> MathHistories { get; set; }
  }
}