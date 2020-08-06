using EulerSolver.Solvers;
using System;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver16Tests
    {

        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver16();

            var result = solver.FindSolution();

            Assert.Equal(1, result);
        }

        [Fact]
        public void ReturnsNumDigits()
        {
            var solver = new Solver16();

            double bigExponent = Math.Pow(2, 1000);

            var result = solver.FindNumDigits(bigExponent);

            Assert.Equal(302, result);
        }

        [Fact]
        public void ReturnsNumDigitsProperly()
        {
            var solver = new Solver16();

            double bigNum = 1111222333446;

            var result = solver.FindNumDigits(bigNum);

            Assert.Equal(13, result);
        }

    }
}
