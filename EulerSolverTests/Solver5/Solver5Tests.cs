using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver5Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver5();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

    }
}
