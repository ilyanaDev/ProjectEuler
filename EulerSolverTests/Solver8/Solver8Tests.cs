using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver8Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver8();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

    }
}
