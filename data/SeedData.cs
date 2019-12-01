using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Test.Api.Models;

namespace Test.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(TestContext context)
        {
            if (!context.MathHistories.Any())
            {
                context.MathHistories.AddRange(
                    new MathHistory
                    {
                        Equation = "Squeaky Bone",
                        Answer = "20.99m"
                    },
                    new MathHistory
                    {
                        Equation = "Knotted Rope",
                        Answer = "12.99m"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}