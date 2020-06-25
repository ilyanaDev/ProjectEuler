using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver4Tests
    {

        [Fact]
        public void ReturnsTrueGivenPalindrome()
        {
            var solver = new Solver4();

            var result = solver.isPalindrome(10001);

            Assert.Equal(true, result);
        }

        [Fact]
        public void ReturnsFalseGivenNonPalindrome()
        {
            var solver = new Solver4();

            var result = solver.isPalindrome(951598);

            Assert.Equal(false, result);
        }

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver4();

            var result = solver.FindLargestPalindrome3DigitProduct();

            Assert.Equal(1, result);
        }

    }
}
