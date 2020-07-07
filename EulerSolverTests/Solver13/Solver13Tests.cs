using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver13Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver13();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

    }
}