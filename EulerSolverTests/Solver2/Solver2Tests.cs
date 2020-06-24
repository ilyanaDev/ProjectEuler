using EulerSolver.Solvers;
using System.Collections;
using Xunit;

namespace EulerSolverTests
{
    public class Solver2Tests
    {
       /*[Fact]
        public void ReturnsSequence()
        {
            var solver = new Solver2();

            ArrayList FS = solver.GenerateSequenceUpTo(10);

            var result = FSArrListToString(FS);

            Assert.Equal("", result);
        }*/
        
        [Fact]
        public void ReturnsSolution()
        {
            var solver = new Solver2();

            var result = solver.SumEvenSequenceUpTo(4000000);

            Assert.Equal(1, result);
        }

    }
}
