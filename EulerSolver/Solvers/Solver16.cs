using System;
using System.Collections;
using Tools;

namespace EulerSolver.Solvers
{
    public class Solver16 : ISolver
    {
        // pattern of last digit of 2 exponents: 2, 4, 8, 6 => 1,2,3,4
        // find sum of digits 2^1000

        public double FindSolution()
        {
            double bigNum = Math.Pow(2, 1000);

            //double bigNum = 1071509;

            double result = 0;

            double remaining = bigNum;

            while(remaining > 0)
            {
                double digValue = remaining % 10;

                result += digValue;

                remaining -= digValue;
                remaining /=  10;

            }

            return result;
        }

        public double FindNumDigits(double num)
        {
            int numDigits = 0;

            double remaining = num;

            while (remaining >= 1)
            {
                numDigits++;

                remaining = remaining / 10;
            }

            return numDigits;

        }

        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
