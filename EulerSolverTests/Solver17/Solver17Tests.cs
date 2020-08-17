using EulerSolver.Solvers;
using System;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver17Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver17();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

    }
}
