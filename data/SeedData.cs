using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Calculator.Api.Models;

namespace Calculator.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(CalculatorContext context)
        {
            if (!context.MathHistories.Any())
            {
                context.MathHistories.AddRange(
                    new MathHistory
                    {
                        Equation = "Squeaky Bone",
                        Answer = 20.99
                    },
                    new MathHistory
                    {
                        Equation = "Knotted Rope",
                        Answer = 12.99
                    }
                );

                context.SaveChanges();
            }
        }
    }
}