using System;
using System.Collections;
using Tools;

namespace EulerSolver.Solvers
{
    public class Solver17 : ISolver
    {

        public double FindSolution()
        {
            double bigSum = 0;

            for(int i = 1; i < 1000; i++)
            {
                double littleSum = 0;

                int onesDigit = i % 10;
                int tensDigit = ((i - onesDigit)/10) % 10;
                int hundredsDigit = ((i - onesDigit - (10 * tensDigit))/100);

                if (onesDigit > 9 || tensDigit > 9 || hundredsDigit > 9)
                {
                    return -1;
                }

                if (tensDigit == 1)
                {
                    switch (onesDigit)
                    {
                        case 0:
                            littleSum += 3;
                            break;
                        case 1:
                            littleSum += 6;
                            break;
                        case 2:
                            littleSum += 6;
                            break;
                        case 3:
                            littleSum += 8;
                            break;
                        case 4:
                            littleSum += 8;
                            break;
                        case 5:
                            littleSum += 7;
                            break;
                        case 6:
                            littleSum += 7;
                            break;
                        case 7:
                            littleSum += 9;
                            break;
                        case 8:
                            littleSum += 8;
                            break;
                        case 9:
                            littleSum += 8;
                            break;

                    }

                    onesDigit = 0;

                }

                if (onesDigit > 0)
                {
                    switch (onesDigit)
                    {
                        case 1:
                            littleSum += 3;
                            break;
                        case 2:
                            littleSum += 3;
                            break;
                        case 3:
                            littleSum += 5;
                            break;
                        case 4:
                            littleSum += 4;
                            break;
                        case 5:
                            littleSum += 4;
                            break;
                        case 6:
                            littleSum += 3;
                            break;
                        case 7:
                            littleSum += 5;
                            break;
                        case 8:
                            littleSum += 5;
                            break;
                        case 9:
                            littleSum += 4;
                            break;
                    }

                }

                if (tensDigit > 1)
                {
                    switch (tensDigit)
                    {
                        case 2:
                            littleSum += 6;
                            break;
                        case 3:
                            littleSum += 6;
                            break;
                        case 4:
                            littleSum += 5;
                            break;
                        case 5:
                            littleSum += 5;
                            break;
                        case 6:
                            littleSum += 5;
                            break;
                        case 7:
                            littleSum += 7;
                            break;
                        case 8:
                            littleSum += 6;
                            break;
                        case 9:
                            littleSum += 6;
                            break;
                    }

                }

                if (hundredsDigit > 0)
                {
                    // for "hundred" 
                    littleSum += 7;

                    //for "and"
                    if (onesDigit != 0 || tensDigit != 0)
                    {
                        littleSum += 3;
                    }

                    switch (hundredsDigit)
                    {
                        case 1:
                            littleSum += 3;
                            break;
                        case 2:
                            littleSum += 3;
                            break;
                        case 3:
                            littleSum += 5;
                            break;
                        case 4:
                            littleSum += 4;
                            break;
                        case 5:
                            littleSum += 4;
                            break;
                        case 6:
                            littleSum += 3;
                            break;
                        case 7:
                            littleSum += 5;
                            break;
                        case 8:
                            littleSum += 5;
                            break;
                        case 9:
                            littleSum += 4;
                            break;
                    }


                }

                bigSum += littleSum;
            }

                

            //for i = 1000
            // "one thousand" is 11 letters
            bigSum += 11;

            return bigSum;
        }

        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
