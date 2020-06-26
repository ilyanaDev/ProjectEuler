using System;
using System.Collections;
using Tools;

namespace EulerSolver.Solvers
{
    public class Solver10 : ISolver
    {
        public long FindSolution()
        {
            long sum = 0;

            var TP = new TestPrimes();

            for (int i = 2; i < 2000000; i++)
            {
                if (TP.isPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }


        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
