﻿using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver4Tests
    {

       [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver4();

            var result = solver.FindLargestPalindrome3DigitProduct();

            Assert.Equal(1, result);
        }

    }
}
