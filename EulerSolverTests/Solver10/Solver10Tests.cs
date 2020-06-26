using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver10Tests
    {

        [Fact]
        public void ReturnsPrimesSum()
        {
            var solver = new Solver10();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

    }
}