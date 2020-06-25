using System;
using System.Collections;

namespace EulerSolver.Solvers
{
    public class Solver3 : ISolver
    {
        public long FindLargestPrimeFactorOf(long num)
        {
            if (this.isPrime(num))
            {
                return num;
            }
            
            long largestSoFar = 1;

            for (long i = 2; i < num/2; i++)
            {
                if (i != 2 && i % 2 == 0)
                {
                    i++;
                }
                if (num % i == 0 && this.isPrime(i))
                {
                    largestSoFar = i;
                }
            }

            return largestSoFar;

        }

        public bool isPrime(long num)
        {
            bool result = true;

            for (long i = 2; i < num/2; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    return result;
                }
            }

            return result;

        }

        public string Solve()
        {
            return "";
        }
    }
}
