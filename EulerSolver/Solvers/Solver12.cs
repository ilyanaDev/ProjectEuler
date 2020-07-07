using System;
using System.Collections;
using Tools;

namespace EulerSolver.Solvers
{
    public class Solver12 : ISolver
    {

        public long FindSolution()
        {
            long attemptedSolution = 0;

            long iterationNum = 1;

            while (this.FindNumDivisors(attemptedSolution) <= 500)
            {
                //if (iterationNum > 8000)
               // {
               //     return 0;
               // }

                attemptedSolution = this.GenerateTriangleNumber(iterationNum);

                iterationNum++;
            }

            return attemptedSolution;
        }

        public long GenerateTriangleNumber(long lastNum)
        {
            // triangle number = number from addition of all natural numbers from 1 to n

            long triNum = 0;

            for (long i = 1; i <= lastNum; i ++)
            {
                triNum += i;
            }

            return triNum;

        }

        public int FindNumDivisors(long subjectNumber)
        {
            int numDivisors = 0;

            for (long i = 1; i <= subjectNumber; i++)
            {
                if (subjectNumber % i == 0)
                {
                    numDivisors++;
                }
            }

            return numDivisors;
        }

        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
