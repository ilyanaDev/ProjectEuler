using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver11Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver11();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

    }
}