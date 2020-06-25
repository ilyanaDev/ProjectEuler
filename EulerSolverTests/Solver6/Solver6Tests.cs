using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver6Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver6();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

    }
}
