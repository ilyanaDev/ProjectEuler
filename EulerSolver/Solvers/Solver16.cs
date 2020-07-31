using System;
using System.Collections;
using Tools;

namespace EulerSolver.Solvers
{
    public class Solver16 : ISolver
    {
        // pattern of last digit of 2 exponents: 2, 4, 8, 6
        // find sum of digits 2^1000

        public double FindSolution()
        {
            double bigNum = Math.Pow(2, 1000);

            double result = 0;

            double remaining = bigNum;

            for(int i = 0; i < 302; i++)
            {
                int digValue = (int)(remaining % 10);

                remaining -= digValue;
                remaining = remaining / 10;

                result += digValue;
            }

            return result;
        }

        public double FindNumDigits(double num)
        {
            string numString = "" + num;

            double result = numString.Length;

            return result;

        }

        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
