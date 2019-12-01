using System;
using System.Text.RegularExpressions;

namespace Calculator.Api.Models
{
  public class MathSolver
  {
    // Takes in an equation and returns the answer
    public static double SolveMath(string equation)
    {
      string pattern = @"[-+*/]";
      Match m = Regex.Match(equation, pattern);
      if (m.Success)
      {
        double answer = ValueParser(equation);
        return answer;
      }
      else
      {
        return Convert.ToDouble(equation);
      }
    }
    public static double ValueParser(string str)
    {
      FinalEquation equation = null;
      if (str.Contains("*"))
      {
        equation = EquationBuilder("*", str);
      }
      else if (str.Contains("/"))
      {
        equation = EquationBuilder("/", str);
      }
      else if (str.Contains("+"))
      {
        equation = EquationBuilder("+", str);
      }
      else if (str.Contains("-"))
      {
        equation = EquationBuilder("-", str);
      }
      return Calculator(equation);
    }
    public static FinalEquation EquationBuilder(string sign, string raw)
    {
      int signPosition = raw.IndexOf(sign);
      string firstNumber = raw.Substring(0, signPosition);
      string secondNumber = raw.Substring(signPosition + 1);
      FinalEquation finalEquation = new FinalEquation() { first = firstNumber, second = secondNumber, sign = sign };
      return finalEquation;
    }
    public class FinalEquation
    {
      public string first;
      public string second;
      public string sign;
    }
    public static double Calculator(FinalEquation equation)
    {
      switch (equation.sign)
      {
        case "*":
          return Convert.ToDouble(equation.first) * Convert.ToDouble(equation.second);
        case "/":
          return Convert.ToDouble(equation.first) / Convert.ToDouble(equation.second);
        case "+":
          return Convert.ToDouble(equation.first) + Convert.ToDouble(equation.second);
        case "-":
          return Convert.ToDouble(equation.first) - Convert.ToDouble(equation.second);
        default:
          return 0;
      }
    }
  }
}

