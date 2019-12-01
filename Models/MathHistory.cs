using System.ComponentModel.DataAnnotations;

// Name to call later
namespace Test.Api.Models
{
  // Class for future equations to be stored using
  public class MathHistory
  {
    public long Id { get; set; }

    [Required]
    public string Equation { get; set; }

    public double Answer { get; set; }
    // public string Answer { get; set; }
  }
}