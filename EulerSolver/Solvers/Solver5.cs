using System;
using System.Collections;

namespace EulerSolver.Solvers
{
    public class Solver5 : ISolver
    {
        public long FindSolution()
        {

            bool found = false;
            
            int result = 0;

            int counter = 1;

            while (!found)
            {
                if(counter%2 == 0 &&
                    counter%3==0 &&
                    counter%4==0 &&
                    counter%5==0 &&
                    counter%6==0 &&
                    counter%7==0 &&
                    counter%8==0 &&
                    counter%9==0 &&
                    counter%10==0 &&
                    counter%11==0 &&
                    counter%12==0 &&
                    counter%13==0 &&
                    counter%14==0 &&
                    counter%15==0 &&
                    counter%16==0 &&
                    counter%17==0 &&
                    counter%18==0 &&
                    counter%19==0 &&
                    counter%20==0)
                {
                    result = counter;
                    found = true;
                }
                counter++;
            }

            return result;

        }


        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

    }

