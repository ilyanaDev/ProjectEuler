using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver3Tests
    {

        [Fact]
        public void ReturnsFalseGiven6()
        {
            var solver = new Solver3();

            var result = solver.isPrime(6);

            Assert.Equal(false, result);
        }

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver3();

            var result = solver.FindLargestPrimeFactorOf(600851475143);

            Assert.Equal(1, result);
        }

    }
}
