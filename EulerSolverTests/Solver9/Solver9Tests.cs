using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver9Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver9();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

        [Fact]
        public void ReturnsTrueGivenPythag()
        {
            var solver = new Solver9();

            var result = solver.isPythag(3, 4, 5);

            Assert.Equal(true, result);
        }

        [Fact]
        public void ReturnsFalseGivenNonPythag()
        {
            var solver = new Solver9();

            var result = solver.isPythag(3, 4, 12);

            Assert.Equal(false, result);
        }

    }
}
