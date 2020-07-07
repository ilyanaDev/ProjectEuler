using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver12Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver12();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

        [Fact]
        public void Returns6Given28()
        {
            var solver = new Solver12();

            var result = solver.FindNumDivisors(28);

            Assert.Equal(6, result);
        }

    }
}