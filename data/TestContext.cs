using Microsoft.EntityFrameworkCore;
using Test.Api.Models;

// Name to call later
namespace Test.Api.Data
{
  // Class to interact with database
  public class TestContext : DbContext
  {
    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public DbSet<MathHistory> MathHistories { get; set; }
  }
}