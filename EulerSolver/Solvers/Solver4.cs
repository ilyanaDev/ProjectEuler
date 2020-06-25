using System;
using System.Collections;

namespace EulerSolver.Solvers
{
    public class Solver4 : ISolver
    {
        public long FindLargestPalindrome3DigitProduct()
        {

            int largestSoFar = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int temp = i*j;

                    if(this.isPalindrome(temp) && temp > largestSoFar)
                    {
                        largestSoFar = temp;
                    }

                }
            }
            return largestSoFar;

        }

        public bool isPalindrome(int num)
        {

            String numString = num.ToString();

            int length = numString.Length;

            for (int i = 0; i < length/2; i++)
            {
                if (numString.Substring(i,1).Equals(numString.Substring(length-(1+i),1)))
                {
                    if (i == (length/2)-1)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }

           return true;

        }

        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

    }

