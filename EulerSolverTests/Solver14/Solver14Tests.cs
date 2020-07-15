using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver14Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver14();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

        [Fact]
        public void ReturnsChainLength()
        {
            var solver = new Solver14();

            var result = solver.ChainLength(999993);

            Assert.Equal(1, result);
        }

    }
}