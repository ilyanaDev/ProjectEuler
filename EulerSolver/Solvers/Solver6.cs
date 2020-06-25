using System;
using System.Collections;

namespace EulerSolver.Solvers
{
    public class Solver6 : ISolver
    {
        public long FindSolution()
        {
            long result = 0;

            long sumSquares = 385;
            long sum = 55;

            for(int i = 11; i <= 100; i++)
            {
                sumSquares += i * i;
                sum += i;

            }

            long squaredSum = sum * sum;

            result = squaredSum - sumSquares;

            return result;

        }


        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
