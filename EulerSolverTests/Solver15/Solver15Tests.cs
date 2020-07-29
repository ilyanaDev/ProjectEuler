using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver15Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver15();

            var result = solver.FindSolution(20);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Returns6Given2()
        {
            var solver = new Solver15();

            var result = solver.FindSolution(2);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Returns2Given1()
        {
            var solver = new Solver15();

            var result = solver.FindSolution(1);

            Assert.Equal(2, result);
        }

        /**[Fact]
        public void Returns26Given3()
        {
            var solver = new Solver15();

            var result = solver.FindSolution(3);

            Assert.Equal(26, result);
        }**/

        [Fact]
        public void FactorialReturns6Given3()
        {
            var solver = new Solver15();

            var result = solver.FindFactorial(3);

            Assert.Equal(6, result);
        }

        [Fact]
        public void FactorialReturns24Given4()
        {
            var solver = new Solver15();

            var result = solver.FindFactorial(4);

            Assert.Equal(24, result);
        }

    }
}
