using System;
using System.Collections;

namespace EulerSolver.Solvers
{
    public class Solver8 : ISolver
    {
        public long FindSolution()
        {
            int numPrimes = 0;

            long counter = 2;

            long result = 0;

            while (numPrimes <= 10001)
            {
                if (this.isPrime(counter))
                {
                    numPrimes++;
                    result = counter;
                }

                counter++;
            }

            return result;

        }

        public bool isPrime(long num)
        {
            bool result = true;

            for (long i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    return result;
                }
            }

            return result;

        }



        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
